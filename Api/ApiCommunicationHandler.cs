using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Ollamas_Unplugged_Personality.Api
{
    /// <summary>
    /// Handles communication with an external API 
    /// for sending requests and processing responses.
    /// </summary>
    public class ApiCommunicationHandler : IApiCommunicationHandler
    {
        private readonly string _baseUrl;
        private static readonly HttpClient _httpClient = new();

        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="ApiCommunicationHandler"/> 
        /// class with a specified base URL.
        /// </summary>
        /// <param name="baseUrl">The base URL for the API.</param>
        public ApiCommunicationHandler(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// Sends a request to the API with the specified prompt and model.
        /// </summary>
        /// <param name="prompt">The input prompt for the API request.</param>
        /// <param name="model">The model to use for the request.</param>
        /// <returns>A task that represents the asynchronous operation, 
        /// with the response string as the result.</returns>
        public async Task<string> SendRequestAsync(string prompt, string model)
        {
            // Set request headers to accept JSON responses
            _httpClient.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Create the message payload
            var message = new { model, prompt };
            string jsonMessage = JsonSerializer.Serialize(message);

            // Create HTTP content for the request
            StringContent content = new StringContent(jsonMessage,
                                                      Encoding.UTF8,
                                                      "application/json");

            try
            {
                // Send the POST request to the API endpoint
                HttpResponseMessage response =
                    await _httpClient.PostAsync(_baseUrl, content);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read and process the response content
                string responseContent =
                    await response.Content.ReadAsStringAsync();

                return ExtractResponse(responseContent);
            }
            catch (HttpRequestException ex)
            {
                // Handle communication errors
                return $"Error communicating with the model: {ex.Message}";
            }
        }

        /// <summary>
        /// Extracts the response content from a JSON response string.
        /// Handles cases with multiple JSON objects separated by line breaks.
        /// </summary>
        /// <param name="jsonResponse">The JSON response string.</param>
        /// <returns>The extracted response text or an error message if parsing fails.</returns>
        private string ExtractResponse(string jsonResponse)
        {
            try
            {
                // Split the response into individual lines to handle multiple JSON objects
                var jsonLines =
                    jsonResponse.Split(
                        ['\n', '\r'],
                        StringSplitOptions.RemoveEmptyEntries);

                var fullResponse = new StringBuilder();

                // Process each line of the JSON response
                foreach (var jsonLine in jsonLines)
                {
                    try
                    {
                        using (JsonDocument doc = JsonDocument.Parse(jsonLine))
                        {
                            // Extract the "response" property if available
                            if (doc.RootElement.TryGetProperty("response",
                                                               out var responseElement))
                            {
                                var responseText = responseElement.GetString();
                                if (!string.IsNullOrWhiteSpace(responseText))
                                {
                                    fullResponse.Append(responseText);
                                }
                            }
                        }
                    }
                    catch (JsonException ex)
                    {
                        // Log parsing errors and continue with other lines
                        Console.WriteLine($"Error parsing JSON line: {ex.Message}");
                        continue;
                    }
                }

                // Return the full response or a default message if no response was found
                return fullResponse.Length > 0
                    ? fullResponse.ToString()
                    : "No response.";
            }
            catch (JsonException ex)
            {
                // Handle errors during response parsing
                return $"Error parsing response: {ex.Message}";
            }
        }
    }
}

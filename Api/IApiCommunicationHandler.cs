namespace Ollamas_Unplugged_Personality.Api
{
    /// <summary>
    /// Defines a contract for handling API communication 
    /// to send requests and receive responses.
    /// </summary>
    public interface IApiCommunicationHandler
    {
        /// <summary>
        /// Sends an asynchronous request 
        /// to the API with the specified prompt and model.
        /// </summary>
        /// <param name="prompt">The input prompt to be sent in the request.</param>
        /// <param name="model">The model to be used for processing the request.</param>
        /// <returns>A task representing the asynchronous operation, 
        /// with the response string as the result.</returns>
        Task<string> SendRequestAsync(string prompt, string model);
    }
}

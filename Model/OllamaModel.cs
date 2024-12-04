using Ollamas_Unplugged_Personality.Api;
using Ollamas_Unplugged_Personality.Entity;

namespace Ollamas_Unplugged_Personality.Model
{
    /// <summary>
    /// Represents an Ollama model that extends 
    /// the functionality of the base Ollama entity.
    /// Manages custom behavior for prompt generation, 
    /// including an initial introduction.
    /// </summary>
    public class OllamaModel : OllamaEntity
    {
        private bool _initialPrompt = true;

        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="OllamaModel"/> class.
        /// </summary>
        /// <param name="apiHandler">
        /// The API communication handler to be used by the model.</param>
        public OllamaModel(IApiCommunicationHandler apiHandler) : base(apiHandler) { }

        /// <summary>
        /// Builds a custom prompt for the model 
        /// based on whether it is the initial interaction.
        /// Includes an introduction on the first interaction 
        /// and reuses the base prompt logic afterward.
        /// </summary>
        /// <param name="input">The input text provided by the user.</param>
        /// <returns>The constructed prompt string for the interaction.</returns>
        protected override string BuildPrompt(string input)
        {
            // Add an introduction on the first prompt interaction
            if (_initialPrompt)
            {
                CustomPrompt = "Please introduce yourself.";
                string introduction = GeneratePersonalProfile();
                _initialPrompt = false;
                return $"{introduction} {CustomPrompt} {input}.";
            }
            else
            {
                // Use base prompt logic for subsequent interactions
                return base.BuildPrompt(input);
            }
        }
    }
}

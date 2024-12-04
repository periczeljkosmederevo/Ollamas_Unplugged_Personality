namespace Ollamas_Unplugged_Personality.Model
{
    /// <summary>
    /// Represents the configuration settings for an Ollama model, including various attributes such as personality, language, and response settings.
    /// </summary>
    public class OllamaConfigurationModel
    {
        /// <summary>
        /// Gets or sets the name of the configuration.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the model name used in the configuration.
        /// </summary>
        public string Model { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether fact-checking is enabled.
        /// </summary>
        public bool FactCheckingEnabled { get; set; } = false;

        /// <summary>
        /// Gets or sets the personality setting for the model.
        /// </summary>
        public string Personality { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the gender setting for the model.
        /// </summary>
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the language setting for the model.
        /// </summary>
        public string Language { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the role setting for the model.
        /// </summary>
        public string Role { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the field of expertise for the model.
        /// </summary>
        public string FieldOfExpertise { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the response length setting for the model.
        /// </summary>
        public string ResponseLength { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the tone setting for the model.
        /// </summary>
        public string Tone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the creativity level setting for the model.
        /// </summary>
        public string CreativityLevel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detail level setting for the model.
        /// </summary>
        public string DetailLevel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the politeness level setting for the model.
        /// </summary>
        public string PolitenessLevel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the conversation style setting for the model.
        /// </summary>
        public string ConversationStyle { get; set; } = string.Empty;
    }
}

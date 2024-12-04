namespace Ollamas_Unplugged_Personality.Model
{
    /// <summary>
    /// Represents a single entry in a conversation, 
    /// including the input, response, and timestamp of the interaction.
    /// </summary>
    public class ConversationEntry
    {
        /// <summary>
        /// Gets or sets the input text for the conversation entry.
        /// </summary>
        public string Input { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the response text for the conversation entry.
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp indicating when the conversation entry occurred.
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}

namespace Ollamas_Unplugged_Personality.Utilities
{
    /// <summary>
    /// Provides utility methods for 
    /// resetting conversation-related controls in the main form.
    /// </summary>
    public static class OllamaConversationResetter
    {
        /// <summary>
        /// Resets the conversation-related controls on the specified form, 
        /// clearing text inputs and resetting the button text.
        /// </summary>
        /// <param name="form">The form to reset.</param>
        public static void Reset(MainForm form)
        {
            // Clear the text in the main conversation display TextBox
            form.Ollama_TextBox.Clear();

            // Clear the input TextBox for user responses
            form.Get_Response_TextBox.Clear();

            // Reset the text of the response button to its default value
            form.Get_Response_Button.Text = "Get response";
        }
    }
}

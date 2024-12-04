using System.Text;
using Ollamas_Unplugged_Personality.Model;

namespace Ollamas_Unplugged_Personality.Utilities
{
    /// <summary>
    /// Provides utility methods for 
    /// loading, saving, and managing Ollama configuration models.
    /// Handles file input/output operations for configuration persistence.
    /// </summary>
    public static class OllamaConfigurationModelIO
    {
        /// <summary>
        /// Loads an Ollama configuration model from the specified file path.
        /// </summary>
        /// <param name="filePath">
        /// The file path of the configuration to load.
        /// </param>
        /// <returns>The loaded configuration model, 
        /// or a new model if an error occurs.
        /// </returns>
        public static OllamaConfigurationModel LoadConfiguration(string filePath)
        {
            var config = new OllamaConfigurationModel();

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    // Read configuration properties line by line
                    config.Name = reader.ReadLine() ?? string.Empty;
                    config.Model = reader.ReadLine() ?? string.Empty;
                    config.FactCheckingEnabled = bool.TryParse(
                        reader.ReadLine(),
                        out var factChecking) && factChecking;
                    config.Personality = reader.ReadLine() ?? string.Empty;
                    config.Gender = reader.ReadLine() ?? string.Empty;
                    config.Language = reader.ReadLine() ?? string.Empty;
                    config.Role = reader.ReadLine() ?? string.Empty;
                    config.FieldOfExpertise = reader.ReadLine() ?? string.Empty;
                    config.ResponseLength = reader.ReadLine() ?? string.Empty;
                    config.Tone = reader.ReadLine() ?? string.Empty;
                    config.CreativityLevel = reader.ReadLine() ?? string.Empty;
                    config.DetailLevel = reader.ReadLine() ?? string.Empty;
                    config.PolitenessLevel = reader.ReadLine() ?? string.Empty;
                    config.ConversationStyle = reader.ReadLine() ?? string.Empty;
                }
            }
            catch (IOException ex)
            {
                // Display an error message if loading fails
                DisplayErrorMessage(
                    $"Error when loading configuration: {ex.Message}", 
                    $"Loading Configuration Error!");
            }

            return config;
        }

        /// <summary>
        /// Saves an Ollama configuration model to the specified file path.
        /// </summary>
        /// <param name="config">
        /// The configuration model to save.
        /// </param>
        /// <param name="filePath">
        /// The file path where the configuration should be saved.
        /// </param>
        public static void SaveConfiguration(OllamaConfigurationModel config,
                                             string filePath)
        {
            try
            {
                // Ensure the directory exists
                Directory.CreateDirectory(
                    Path.GetDirectoryName(filePath) ?? string.Empty);

                using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Write configuration properties line by line
                    writer.WriteLine(config.Name);
                    writer.WriteLine(config.Model);
                    writer.WriteLine(config.FactCheckingEnabled);
                    writer.WriteLine(config.Personality);
                    writer.WriteLine(config.Gender);
                    writer.WriteLine(config.Language);
                    writer.WriteLine(config.Role);
                    writer.WriteLine(config.FieldOfExpertise);
                    writer.WriteLine(config.ResponseLength);
                    writer.WriteLine(config.Tone);
                    writer.WriteLine(config.CreativityLevel);
                    writer.WriteLine(config.DetailLevel);
                    writer.WriteLine(config.PolitenessLevel);
                    writer.WriteLine(config.ConversationStyle);
                }
            }
            catch (IOException ex)
            {
                // Display an error message if saving fails
                DisplayErrorMessage(
                    $"Error when saving configuration: {ex.Message}", 
                    $"Saving Configuration Error!");
            }
        }

        /// <summary>
        /// Retrieves a list of available configurations
        /// from the specified directory.
        /// </summary>
        /// <param name="directoryPath">
        /// The directory to search for configurations.</param>
        /// <returns>
        /// An array of configuration names without extensions.</returns>
        public static string[] GetAvailableConfigurations(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                // Create the directory if it does not exist
                Directory.CreateDirectory(directoryPath);
            }

            return Directory.GetFiles(directoryPath, "*.configuration")
                            .Select(Path.GetFileNameWithoutExtension)
                            .ToArray()!;
        }

        /// <summary>
        /// Opens a save file dialog 
        /// and returns the selected file path.
        /// </summary>
        /// <param name="saveFileDialog">
        /// The SaveFileDialog instance to use.</param>
        /// <param name="initialDirectory">
        /// The initial directory to open in the dialog.</param>
        /// <returns>
        /// The selected file path, 
        /// or an empty string if no file is selected.
        /// </returns>
        public static string GetSaveFilePath(SaveFileDialog saveFileDialog,
                                             string initialDirectory)
        {
            saveFileDialog.InitialDirectory = Path.GetFullPath(initialDirectory);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return string.Empty;
        }

        /// <summary>
        /// Determines whether there are any available
        /// configurations in the specified directory.
        /// </summary>
        /// <param name="directoryPath">
        /// The directory to check for configurations.
        /// </param>
        /// <returns>
        /// True if configurations are found; otherwise, false.
        /// </returns>
        public static bool HasConfigurations(string directoryPath)
        {
            return Directory.Exists(directoryPath) 
                && Directory.GetFiles(directoryPath, "*.configuration").Length != 0;
        }

        /// <summary>
        /// Displays an error message in a message box.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        /// <param name="title">The title of the message box.</param>
        private static void DisplayErrorMessage(string message, string title)
        {
            MessageBox.Show(message,
                            title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}

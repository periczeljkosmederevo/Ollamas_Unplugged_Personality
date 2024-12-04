using Ollamas_Unplugged_Personality.Enums;
using Ollamas_Unplugged_Personality.Extensions;

namespace Ollamas_Unplugged_Personality.Utilities
{
    /// <summary>
    /// Provides utility methods for populating dropdowns
    /// in the main form with enum values and model configurations.
    /// </summary>
    public static class OllamaModelConfigurationDropdownPopulator
    {
        /// <summary>
        /// Populates the dropdowns in the form
        /// with values from various enums.
        /// </summary>
        /// <param name="form">
        /// The main form containing the dropdown controls.
        /// </param>
        public static async Task PopulateDropdowns(MainForm form)
        {
            // Populate each dropdown with corresponding enum values
            form.ConversationStyle_ComboBox.PopulateWithEnumValues<ConversationStyle>();
            form.CreativityLevel_ComboBox.PopulateWithEnumValues<CreativityLevel>();
            form.DetailLevel_ComboBox.PopulateWithEnumValues<DetailLevel>();
            form.FieldOfExpertise_ComboBox.PopulateWithEnumValues<FieldOfExpertise>();
            form.Gender_ComboBox.PopulateWithEnumValues<Gender>();
            form.Language_ComboBox.PopulateWithEnumValues<Language>();
            form.Personality_ComboBox.PopulateWithEnumValues<Personality>();
            form.PolitenessLevel_ComboBox.PopulateWithEnumValues<PolitenessLevel>();
            form.ResponseLength_ComboBox.PopulateWithEnumValues<ResponseLength>();
            form.Role_ComboBox.PopulateWithEnumValues<Role>();
            form.Tone_ComboBox.PopulateWithEnumValues<Tone>();

            // Populate Ollama models asynchronously
            await PopulateOllamaModelDropdownAsync(form);
        }

        /// <summary>
        /// Populates the configurations dropdown
        /// with available configuration files from the specified directory.
        /// </summary>
        /// <param name="form">
        /// The main form containing the configurations dropdown.
        /// </param>
        /// <param name="configDirectory">
        /// The directory to search for configuration files.
        /// </param>
        public static void PopulateConfigurationsDropdown(MainForm form,
                                                          string configDirectory)
        {
            // Ensure the configuration directory exists
            if (!Directory.Exists(configDirectory))
            {
                Directory.CreateDirectory(configDirectory);
            }

            // Retrieve configuration files
            // and add their names (without extensions) to the dropdown
            var configFiles = Directory.GetFiles(configDirectory,
                                                 "*.configuration");

            form.OllamaModelConfigurations_ComboBox.Items.Clear();

            if (configFiles.Length > 0)
            {
                form.OllamaModelConfigurations_ComboBox.Items
                    .AddRange(configFiles.Select(Path.GetFileNameWithoutExtension)
                    .ToArray()!);
            }
        }

        /// <summary>
        /// Asynchronously populates the Ollama model dropdown
        /// with available models retrieved via a command-line command.
        /// </summary>
        /// <param name="form">
        /// The main form containing the Ollama model dropdown.
        /// </param>
        private static async Task PopulateOllamaModelDropdownAsync(MainForm form)
        {
            // Retrieve model names by executing a command-line command
            string output = await Task.Run(() => 
                CmdCommandRunner.RunCommand("ollama", "list"));

            if (!string.IsNullOrEmpty(output))
            {
                // Extract model names from the command output
                var modelNames = output
                    .Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries)
                    // Skip the header line if present
                    .Skip(1)
                    // Take the first word as the model name
                    .Select(line => line.Split(' ')[0])
                    .ToList();

                // Populate the dropdown with the model names
                form.OllamaModel_ComboBox.DataSource = modelNames;
            }
            else
            {
                // Display an error message if no models are found or retrieval fails
                MessageBox.Show("No models found or failed to retrieve models.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}

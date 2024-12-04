using Ollamas_Unplugged_Personality.Enums;

namespace Ollamas_Unplugged_Personality.Model
{
    /// <summary>
    /// Provides methods for configuring and managing Ollama model settings.
    /// Allows applying configurations to form controls and updating model properties.
    /// </summary>
    public static class OllamaModelConfigurator
    {
        /// <summary>
        /// Applies a configuration model to a form, 
        /// updating form controls to reflect the configuration settings.
        /// </summary>
        /// <param name="form">The form to update with the configuration settings.</param>
        /// <param name="config">The configuration model containing settings to apply.</param>
        public static void ApplyConfigurationToForm(MainForm form, OllamaConfigurationModel config)
        {
            form.OllamaModelName_TextBox.Text = config.Name;
            form.OllamaModel_ComboBox.SelectedItem = config.Model;
            form.FactChecingEnabled_RadioButton.Checked = config.FactCheckingEnabled;
            form.FactChecingDisabled_RadioButton.Checked = !config.FactCheckingEnabled;
            form.Personality_ComboBox.SelectedItem = config.Personality;
            form.Gender_ComboBox.SelectedItem = config.Gender;
            form.Language_ComboBox.SelectedItem = config.Language;
            form.Role_ComboBox.SelectedItem = config.Role;
            form.FieldOfExpertise_ComboBox.SelectedItem = config.FieldOfExpertise;
            form.ResponseLength_ComboBox.SelectedItem = config.ResponseLength;
            form.Tone_ComboBox.SelectedItem = config.Tone;
            form.CreativityLevel_ComboBox.SelectedItem = config.CreativityLevel;
            form.DetailLevel_ComboBox.SelectedItem = config.DetailLevel;
            form.PolitenessLevel_ComboBox.SelectedItem = config.PolitenessLevel;
            form.ConversationStyle_ComboBox.SelectedItem = config.ConversationStyle;
        }

        /// <summary>
        /// Configures the specified Ollama model with the provided configuration settings.
        /// </summary>
        /// <param name="model">The Ollama model to configure.</param>
        /// <param name="config">The configuration settings to apply.</param>
        public static void ConfigureModel(OllamaModel model, OllamaConfigurationModel config)
        {
            model.Name = config.Name ?? string.Empty;
            model.Model = config.Model ?? string.Empty;
            model.FactCheckingEnabled = config.FactCheckingEnabled;

            // Centralized Enum Parsing Logic
            model.Personality = ParseEnumOrDefault(config.Personality, Personality.Neutral);
            model.Gender = ParseEnumOrDefault(config.Gender, Gender.Male);
            model.Language = ParseEnumOrDefault(config.Language, Language.English);
            model.Role = ParseEnumOrDefault(config.Role, Role.Participant);
            model.FieldOfExpertise = ParseEnumOrDefault(config.FieldOfExpertise, FieldOfExpertise.General);
            model.ResponseLength = ParseEnumOrDefault(config.ResponseLength, ResponseLength.Normal);
            model.Tone = ParseEnumOrDefault(config.Tone, Tone.Neutral);
            model.CreativityLevel = ParseEnumOrDefault(config.CreativityLevel, CreativityLevel.Balanced);
            model.DetailLevel = ParseEnumOrDefault(config.DetailLevel, DetailLevel.Moderate);
            model.PolitenessLevel = ParseEnumOrDefault(config.PolitenessLevel, PolitenessLevel.Neutral);
            model.ConversationStyle = ParseEnumOrDefault(config.ConversationStyle, ConversationStyle.Listener);
        }

        /// <summary>
        /// Retrieves configuration settings from a form and creates a configuration model.
        /// </summary>
        /// <param name="form">The form containing the configuration data.</param>
        /// <returns>A configuration model populated with settings from the form.</returns>
        public static OllamaConfigurationModel GetConfigurationFromForm(MainForm form)
        {
            return new OllamaConfigurationModel
            {
                Name = form.OllamaModelName_TextBox.Text,
                Model = form.OllamaModel_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                FactCheckingEnabled = form.FactChecingEnabled_RadioButton.Checked,
                Personality = form.Personality_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                Gender = form.Gender_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                Language = form.Language_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                Role = form.Role_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                FieldOfExpertise = form.FieldOfExpertise_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                ResponseLength = form.ResponseLength_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                Tone = form.Tone_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                CreativityLevel = form.CreativityLevel_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                DetailLevel = form.DetailLevel_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                PolitenessLevel = form.PolitenessLevel_ComboBox.SelectedItem?.ToString() ?? string.Empty,
                ConversationStyle = form.ConversationStyle_ComboBox.SelectedItem?.ToString() ?? string.Empty
            };
        }

        /// <summary>
        /// Parses a string value into an enum value or returns a default value if parsing fails.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The string value to parse.</param>
        /// <param name="defaultValue">The default value to return if parsing fails.</param>
        /// <returns>The parsed enum value, or the default value if parsing fails.</returns>
        private static T ParseEnumOrDefault<T>(string value, T defaultValue) where T : struct
        {
            return Enum.TryParse(value, out T result) ? result : defaultValue;
        }
    }
}

using Ollamas_Unplugged_Personality.Api;
using Ollamas_Unplugged_Personality.Model;
using Ollamas_Unplugged_Personality.Utilities;

namespace Ollamas_Unplugged_Personality
{
    /// <summary>
    /// Main form of the application responsible
    /// for managing interactions with the Ollama model.
    /// Handles user input, 
    /// configuration management, and response generation.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly OllamaModel _ollama;
        private OllamaConfigurationModel _config = new();

        // Constants for configuration paths and API URL
        private const string _configDirectory = "Configurations";
        private const string _defaultConfigFileExtension = ".configuration";
        private const string _apiUrl = "http://localhost:11434/api/generate";

        private bool _initializationIsFinished;

        /// <summary>
        /// Initializes the MainForm 
        /// and sets up the Ollama model and form controls.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _ollama = new OllamaModel(new ApiCommunicationHandler(_apiUrl));

            InitializeForm();
        }

        /// <summary>
        /// Asynchronously initializes the form 
        /// by resetting conversation, 
        /// populating dropdowns, and setting up configurations.
        /// </summary>
        private async void InitializeForm()
        {
            // Reset the conversation state
            OllamaConversationResetter.Reset(this);

            // Populate dropdowns with available model configurations
            await OllamaModelConfigurationDropdownPopulator
                .PopulateDropdowns(this);

            // Populate available configurations in the dropdown
            OllamaModelConfigurationDropdownPopulator
                .PopulateConfigurationsDropdown(this, _configDirectory);

            _initializationIsFinished = true;
        }

        /// <summary>
        /// Handles the button click event 
        /// to generate a response from the Ollama model.
        /// </summary>
        private async void GetResponse_Button_Click(object sender, EventArgs e)
        {
            // Ensure there is input to process
            if (!string.IsNullOrWhiteSpace(Get_Response_TextBox.Text))
            {
                Get_Response_Button.Enabled = false;

                // Generate and display the response
                string response = 
                    await _ollama.GenerateResponse(Get_Response_TextBox.Text);

                var formatedResponse = $"\n{_ollama.Name}\n{response}\n***\n";

                Ollama_TextBox.Text += formatedResponse;
                    

                Get_Response_Button.Enabled = true;
            }
        }

        #region Configuration IO

        /// <summary>
        /// Saves the current configuration to a file.
        /// </summary>
        private void SaveConfiguration()
        {
            string filePath = OllamaConfigurationModelIO
                .GetSaveFilePath(Configuration_SaveFileDialog,
                                 initialDirectory: _configDirectory);

            if (!string.IsNullOrEmpty(filePath))
            {
                // Get and save the configuration from the form
                _config = OllamaModelConfigurator
                    .GetConfigurationFromForm(this);

                OllamaConfigurationModelIO
                    .SaveConfiguration(_config, filePath);

                // Refresh the configuration dropdown
                OllamaModelConfigurationDropdownPopulator
                    .PopulateConfigurationsDropdown(this, _configDirectory);

                // Set the newly saved configuration
                // as the selected item in the dropdown
                string newConfigName = Path.GetFileNameWithoutExtension(filePath);
                OllamaModelConfigurations_ComboBox.SelectedItem = newConfigName;
            }
        }

        /// <summary>
        /// Loads a configuration from a specified file.
        /// </summary>
        /// <param name="fileName">The name of the configuration file.</param>
        private void LoadConfiguration(string fileName)
        {
            _config = OllamaConfigurationModelIO
                .LoadConfiguration($"{fileName}{_defaultConfigFileExtension}");

            OllamaModelConfigurator.ApplyConfigurationToForm(this, _config);
            OllamaModelConfigurator.ConfigureModel(_ollama, _config);
        }

        /// <summary>
        /// Handles the Save Configuration button click event.
        /// </summary>
        private void SaveConfiguration_Button_Click(object sender, EventArgs e) => SaveConfiguration();

        #endregion

        #region Automatic Configuration Load

        /// <summary>
        /// Handles the selection change event for the configuration dropdown,
        /// loading the selected configuration.
        /// </summary>
        private void OllamaModelConfigurations_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OllamaModelConfigurations_ComboBox.SelectedItem is string selectedConfig)
            {
                LoadConfiguration(Path.Combine(_configDirectory, selectedConfig));
            }
        }

        #endregion

        #region Configuration Changed

        /// <summary>
        /// Triggered when a configuration-related control is changed, updating the model configuration.
        /// </summary>
        private void OnConfigurationChanged(object sender, EventArgs e)
        {
            if (_initializationIsFinished)
            {
                UpdateConfigurationFromForm();
            }
        }

        /// <summary>
        /// Updates the configuration from the form controls and applies it to the model.
        /// </summary>
        private void UpdateConfigurationFromForm()
        {
            _config = OllamaModelConfigurator.GetConfigurationFromForm(this);
            OllamaModelConfigurator.ConfigureModel(_ollama, _config);
        }

        /// <summary>
        /// Event handler for changes in personality combo boxes.
        /// </summary>
        private void Personality_ComboBoxes_SelectedIndexChanged(object sender, EventArgs e) 
            => OnConfigurationChanged(sender, e);

        /// <summary>
        /// Event handler for changes in the model name text box.
        /// </summary>
        private void OllamaModelName_TextBox_TextChanged(object sender, EventArgs e)
            => OnConfigurationChanged(sender, e);

        /// <summary>
        /// Event handler for changes in the fact-checking radio button.
        /// </summary>
        private void FactChecingEnabled_RadioButton_CheckedChanged(object sender, EventArgs e)
            => OnConfigurationChanged(sender, e);

        #endregion
    }
}

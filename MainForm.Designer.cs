namespace Ollamas_Unplugged_Personality;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        Ollama_TextBox = new RichTextBox();
        Get_Response_TextBox = new RichTextBox();
        Get_Response_Button = new Button();
        Ollama_Label = new Label();
        ConversationStyle_ComboBox = new ComboBox();
        CreativityLevel_ComboBox = new ComboBox();
        ConversationStyle_Label = new Label();
        label2 = new Label();
        FieldOfExpertise_Label = new Label();
        DetailLevel_label = new Label();
        FieldOfExpertise_ComboBox = new ComboBox();
        DetailLevel_ComboBox = new ComboBox();
        Language_Label = new Label();
        Gender_Label = new Label();
        Language_ComboBox = new ComboBox();
        Gender_ComboBox = new ComboBox();
        PolitenessLevel_Label = new Label();
        Personality_Label = new Label();
        PolitenessLevel_ComboBox = new ComboBox();
        Personality_ComboBox = new ComboBox();
        Role_Label = new Label();
        ResponseLength_Label = new Label();
        Role_ComboBox = new ComboBox();
        ResponseLength_ComboBox = new ComboBox();
        Tone_Label = new Label();
        Tone_ComboBox = new ComboBox();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        groupBox3 = new GroupBox();
        groupBox4 = new GroupBox();
        groupBox5 = new GroupBox();
        groupBox6 = new GroupBox();
        groupBox10 = new GroupBox();
        SaveConfiguration_Button = new Button();
        label3 = new Label();
        OllamaModelConfigurations_ComboBox = new ComboBox();
        groupBox9 = new GroupBox();
        FactChecingDisabled_RadioButton = new RadioButton();
        FactChecingEnabled_RadioButton = new RadioButton();
        groupBox8 = new GroupBox();
        OllamaModelName_TextBox = new TextBox();
        label1 = new Label();
        groupBox7 = new GroupBox();
        OllamaModel_Label = new Label();
        OllamaModel_ComboBox = new ComboBox();
        Configuration_SaveFileDialog = new SaveFileDialog();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox10.SuspendLayout();
        groupBox9.SuspendLayout();
        groupBox8.SuspendLayout();
        groupBox7.SuspendLayout();
        SuspendLayout();
        // 
        // Ollama_TextBox
        // 
        Ollama_TextBox.BackColor = Color.White;
        Ollama_TextBox.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Ollama_TextBox.Location = new Point(12, 44);
        Ollama_TextBox.Name = "Ollama_TextBox";
        Ollama_TextBox.ReadOnly = true;
        Ollama_TextBox.Size = new Size(680, 545);
        Ollama_TextBox.TabIndex = 0;
        Ollama_TextBox.TabStop = false;
        Ollama_TextBox.Text = "";
        // 
        // Get_Response_TextBox
        // 
        Get_Response_TextBox.BackColor = Color.White;
        Get_Response_TextBox.Location = new Point(12, 595);
        Get_Response_TextBox.Name = "Get_Response_TextBox";
        Get_Response_TextBox.Size = new Size(680, 200);
        Get_Response_TextBox.TabIndex = 1;
        Get_Response_TextBox.Text = "Ask a question";
        // 
        // Get_Response_Button
        // 
        Get_Response_Button.Location = new Point(12, 801);
        Get_Response_Button.Name = "Get_Response_Button";
        Get_Response_Button.Size = new Size(680, 48);
        Get_Response_Button.TabIndex = 3;
        Get_Response_Button.Text = "Get Response";
        Get_Response_Button.UseVisualStyleBackColor = true;
        Get_Response_Button.Click += GetResponse_Button_Click;
        // 
        // Ollama_Label
        // 
        Ollama_Label.AutoSize = true;
        Ollama_Label.Location = new Point(12, 18);
        Ollama_Label.Name = "Ollama_Label";
        Ollama_Label.Size = new Size(59, 18);
        Ollama_Label.TabIndex = 4;
        Ollama_Label.Text = "Ollama";
        // 
        // ConversationStyle_ComboBox
        // 
        ConversationStyle_ComboBox.FormattingEnabled = true;
        ConversationStyle_ComboBox.Location = new Point(31, 110);
        ConversationStyle_ComboBox.Name = "ConversationStyle_ComboBox";
        ConversationStyle_ComboBox.Size = new Size(200, 26);
        ConversationStyle_ComboBox.TabIndex = 5;
        ConversationStyle_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // CreativityLevel_ComboBox
        // 
        CreativityLevel_ComboBox.FormattingEnabled = true;
        CreativityLevel_ComboBox.Location = new Point(33, 160);
        CreativityLevel_ComboBox.Name = "CreativityLevel_ComboBox";
        CreativityLevel_ComboBox.Size = new Size(200, 26);
        CreativityLevel_ComboBox.TabIndex = 6;
        CreativityLevel_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // ConversationStyle_Label
        // 
        ConversationStyle_Label.AutoSize = true;
        ConversationStyle_Label.Location = new Point(31, 89);
        ConversationStyle_Label.Name = "ConversationStyle_Label";
        ConversationStyle_Label.Size = new Size(147, 18);
        ConversationStyle_Label.TabIndex = 7;
        ConversationStyle_Label.Text = "Conversation style";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(33, 139);
        label2.Name = "label2";
        label2.Size = new Size(117, 18);
        label2.TabIndex = 8;
        label2.Text = "Creativity level";
        // 
        // FieldOfExpertise_Label
        // 
        FieldOfExpertise_Label.AutoSize = true;
        FieldOfExpertise_Label.Location = new Point(31, 27);
        FieldOfExpertise_Label.Name = "FieldOfExpertise_Label";
        FieldOfExpertise_Label.Size = new Size(134, 18);
        FieldOfExpertise_Label.TabIndex = 12;
        FieldOfExpertise_Label.Text = "Field of expertise";
        // 
        // DetailLevel_label
        // 
        DetailLevel_label.AutoSize = true;
        DetailLevel_label.Location = new Point(33, 39);
        DetailLevel_label.Name = "DetailLevel_label";
        DetailLevel_label.Size = new Size(87, 18);
        DetailLevel_label.TabIndex = 11;
        DetailLevel_label.Text = "Detail level";
        // 
        // FieldOfExpertise_ComboBox
        // 
        FieldOfExpertise_ComboBox.FormattingEnabled = true;
        FieldOfExpertise_ComboBox.Location = new Point(31, 48);
        FieldOfExpertise_ComboBox.Name = "FieldOfExpertise_ComboBox";
        FieldOfExpertise_ComboBox.Size = new Size(200, 26);
        FieldOfExpertise_ComboBox.TabIndex = 10;
        FieldOfExpertise_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // DetailLevel_ComboBox
        // 
        DetailLevel_ComboBox.FormattingEnabled = true;
        DetailLevel_ComboBox.Location = new Point(33, 60);
        DetailLevel_ComboBox.Name = "DetailLevel_ComboBox";
        DetailLevel_ComboBox.Size = new Size(200, 26);
        DetailLevel_ComboBox.TabIndex = 9;
        DetailLevel_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // Language_Label
        // 
        Language_Label.AutoSize = true;
        Language_Label.Location = new Point(31, 77);
        Language_Label.Name = "Language_Label";
        Language_Label.Size = new Size(79, 18);
        Language_Label.TabIndex = 16;
        Language_Label.Text = "Language";
        // 
        // Gender_Label
        // 
        Gender_Label.AutoSize = true;
        Gender_Label.Location = new Point(31, 27);
        Gender_Label.Name = "Gender_Label";
        Gender_Label.Size = new Size(62, 18);
        Gender_Label.TabIndex = 15;
        Gender_Label.Text = "Gender";
        // 
        // Language_ComboBox
        // 
        Language_ComboBox.FormattingEnabled = true;
        Language_ComboBox.Location = new Point(31, 98);
        Language_ComboBox.Name = "Language_ComboBox";
        Language_ComboBox.Size = new Size(200, 26);
        Language_ComboBox.TabIndex = 14;
        Language_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // Gender_ComboBox
        // 
        Gender_ComboBox.FormattingEnabled = true;
        Gender_ComboBox.Location = new Point(31, 48);
        Gender_ComboBox.Name = "Gender_ComboBox";
        Gender_ComboBox.Size = new Size(200, 26);
        Gender_ComboBox.TabIndex = 13;
        Gender_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // PolitenessLevel_Label
        // 
        PolitenessLevel_Label.AutoSize = true;
        PolitenessLevel_Label.Location = new Point(32, 26);
        PolitenessLevel_Label.Name = "PolitenessLevel_Label";
        PolitenessLevel_Label.Size = new Size(120, 18);
        PolitenessLevel_Label.TabIndex = 20;
        PolitenessLevel_Label.Text = "Politeness level";
        // 
        // Personality_Label
        // 
        Personality_Label.AutoSize = true;
        Personality_Label.Location = new Point(31, 39);
        Personality_Label.Name = "Personality_Label";
        Personality_Label.Size = new Size(89, 18);
        Personality_Label.TabIndex = 19;
        Personality_Label.Text = "Personality";
        // 
        // PolitenessLevel_ComboBox
        // 
        PolitenessLevel_ComboBox.FormattingEnabled = true;
        PolitenessLevel_ComboBox.Location = new Point(32, 47);
        PolitenessLevel_ComboBox.Name = "PolitenessLevel_ComboBox";
        PolitenessLevel_ComboBox.Size = new Size(200, 26);
        PolitenessLevel_ComboBox.TabIndex = 18;
        PolitenessLevel_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // Personality_ComboBox
        // 
        Personality_ComboBox.FormattingEnabled = true;
        Personality_ComboBox.Location = new Point(31, 60);
        Personality_ComboBox.Name = "Personality_ComboBox";
        Personality_ComboBox.Size = new Size(200, 26);
        Personality_ComboBox.TabIndex = 17;
        Personality_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // Role_Label
        // 
        Role_Label.AutoSize = true;
        Role_Label.Location = new Point(31, 77);
        Role_Label.Name = "Role_Label";
        Role_Label.Size = new Size(40, 18);
        Role_Label.TabIndex = 24;
        Role_Label.Text = "Role";
        // 
        // ResponseLength_Label
        // 
        ResponseLength_Label.AutoSize = true;
        ResponseLength_Label.Location = new Point(33, 89);
        ResponseLength_Label.Name = "ResponseLength_Label";
        ResponseLength_Label.Size = new Size(130, 18);
        ResponseLength_Label.TabIndex = 23;
        ResponseLength_Label.Text = "Response length";
        ResponseLength_Label.TextAlign = ContentAlignment.MiddleRight;
        // 
        // Role_ComboBox
        // 
        Role_ComboBox.FormattingEnabled = true;
        Role_ComboBox.Location = new Point(31, 98);
        Role_ComboBox.Name = "Role_ComboBox";
        Role_ComboBox.Size = new Size(200, 26);
        Role_ComboBox.TabIndex = 22;
        Role_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // ResponseLength_ComboBox
        // 
        ResponseLength_ComboBox.FormattingEnabled = true;
        ResponseLength_ComboBox.Location = new Point(33, 110);
        ResponseLength_ComboBox.Name = "ResponseLength_ComboBox";
        ResponseLength_ComboBox.Size = new Size(200, 26);
        ResponseLength_ComboBox.TabIndex = 21;
        ResponseLength_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // Tone_Label
        // 
        Tone_Label.AutoSize = true;
        Tone_Label.Location = new Point(31, 139);
        Tone_Label.Name = "Tone_Label";
        Tone_Label.Size = new Size(43, 18);
        Tone_Label.TabIndex = 27;
        Tone_Label.Text = "Tone";
        // 
        // Tone_ComboBox
        // 
        Tone_ComboBox.FormattingEnabled = true;
        Tone_ComboBox.Location = new Point(31, 160);
        Tone_ComboBox.Name = "Tone_ComboBox";
        Tone_ComboBox.Size = new Size(200, 26);
        Tone_ComboBox.TabIndex = 25;
        Tone_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(Gender_ComboBox);
        groupBox1.Controls.Add(Language_ComboBox);
        groupBox1.Controls.Add(Gender_Label);
        groupBox1.Controls.Add(Language_Label);
        groupBox1.Location = new Point(11, 156);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(262, 150);
        groupBox1.TabIndex = 28;
        groupBox1.TabStop = false;
        groupBox1.Text = "Demographic";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(ConversationStyle_ComboBox);
        groupBox2.Controls.Add(ConversationStyle_Label);
        groupBox2.Controls.Add(Tone_Label);
        groupBox2.Controls.Add(Tone_ComboBox);
        groupBox2.Controls.Add(Personality_Label);
        groupBox2.Controls.Add(Personality_ComboBox);
        groupBox2.Location = new Point(11, 339);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(262, 225);
        groupBox2.TabIndex = 29;
        groupBox2.TabStop = false;
        groupBox2.Text = "Personality Traits";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(FieldOfExpertise_Label);
        groupBox3.Controls.Add(FieldOfExpertise_ComboBox);
        groupBox3.Controls.Add(Role_Label);
        groupBox3.Controls.Add(Role_ComboBox);
        groupBox3.Location = new Point(279, 156);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(262, 150);
        groupBox3.TabIndex = 30;
        groupBox3.TabStop = false;
        groupBox3.Text = "Expertise and Role";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(PolitenessLevel_Label);
        groupBox4.Controls.Add(PolitenessLevel_ComboBox);
        groupBox4.Location = new Point(547, 156);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(265, 98);
        groupBox4.TabIndex = 31;
        groupBox4.TabStop = false;
        groupBox4.Text = "Interaction Style";
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(DetailLevel_label);
        groupBox5.Controls.Add(DetailLevel_ComboBox);
        groupBox5.Controls.Add(label2);
        groupBox5.Controls.Add(CreativityLevel_ComboBox);
        groupBox5.Controls.Add(ResponseLength_Label);
        groupBox5.Controls.Add(ResponseLength_ComboBox);
        groupBox5.Location = new Point(279, 340);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(267, 225);
        groupBox5.TabIndex = 32;
        groupBox5.TabStop = false;
        groupBox5.Text = "Response Preferences";
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(groupBox10);
        groupBox6.Controls.Add(groupBox9);
        groupBox6.Controls.Add(groupBox8);
        groupBox6.Controls.Add(groupBox7);
        groupBox6.Controls.Add(groupBox5);
        groupBox6.Controls.Add(groupBox1);
        groupBox6.Controls.Add(groupBox4);
        groupBox6.Controls.Add(groupBox2);
        groupBox6.Controls.Add(groupBox3);
        groupBox6.Location = new Point(698, 18);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(874, 571);
        groupBox6.TabIndex = 33;
        groupBox6.TabStop = false;
        groupBox6.Text = "Ollama Model Configuration";
        // 
        // groupBox10
        // 
        groupBox10.Controls.Add(SaveConfiguration_Button);
        groupBox10.Controls.Add(label3);
        groupBox10.Controls.Add(OllamaModelConfigurations_ComboBox);
        groupBox10.Location = new Point(552, 340);
        groupBox10.Name = "groupBox10";
        groupBox10.Size = new Size(262, 224);
        groupBox10.TabIndex = 38;
        groupBox10.TabStop = false;
        groupBox10.Text = "IO";
        // 
        // SaveConfiguration_Button
        // 
        SaveConfiguration_Button.Location = new Point(31, 160);
        SaveConfiguration_Button.Name = "SaveConfiguration_Button";
        SaveConfiguration_Button.Size = new Size(200, 26);
        SaveConfiguration_Button.TabIndex = 13;
        SaveConfiguration_Button.Text = "Save";
        SaveConfiguration_Button.UseVisualStyleBackColor = true;
        SaveConfiguration_Button.Click += SaveConfiguration_Button_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(31, 27);
        label3.Name = "label3";
        label3.Size = new Size(115, 18);
        label3.TabIndex = 12;
        label3.Text = "Configurations";
        // 
        // OllamaModelConfigurations_ComboBox
        // 
        OllamaModelConfigurations_ComboBox.FormattingEnabled = true;
        OllamaModelConfigurations_ComboBox.Location = new Point(31, 48);
        OllamaModelConfigurations_ComboBox.Name = "OllamaModelConfigurations_ComboBox";
        OllamaModelConfigurations_ComboBox.Size = new Size(200, 26);
        OllamaModelConfigurations_ComboBox.TabIndex = 10;
        OllamaModelConfigurations_ComboBox.SelectedIndexChanged += OllamaModelConfigurations_ComboBox_SelectedIndexChanged;
        // 
        // groupBox9
        // 
        groupBox9.Controls.Add(FactChecingDisabled_RadioButton);
        groupBox9.Controls.Add(FactChecingEnabled_RadioButton);
        groupBox9.Location = new Point(547, 25);
        groupBox9.Name = "groupBox9";
        groupBox9.Size = new Size(255, 99);
        groupBox9.TabIndex = 37;
        groupBox9.TabStop = false;
        groupBox9.Text = "Fact-Checking Options";
        // 
        // FactChecingDisabled_RadioButton
        // 
        FactChecingDisabled_RadioButton.AutoSize = true;
        FactChecingDisabled_RadioButton.Checked = true;
        FactChecingDisabled_RadioButton.Location = new Point(140, 38);
        FactChecingDisabled_RadioButton.Name = "FactChecingDisabled_RadioButton";
        FactChecingDisabled_RadioButton.Size = new Size(87, 22);
        FactChecingDisabled_RadioButton.TabIndex = 1;
        FactChecingDisabled_RadioButton.TabStop = true;
        FactChecingDisabled_RadioButton.Text = "Disabled";
        FactChecingDisabled_RadioButton.UseVisualStyleBackColor = true;
        // 
        // FactChecingEnabled_RadioButton
        // 
        FactChecingEnabled_RadioButton.AutoSize = true;
        FactChecingEnabled_RadioButton.Location = new Point(27, 38);
        FactChecingEnabled_RadioButton.Name = "FactChecingEnabled_RadioButton";
        FactChecingEnabled_RadioButton.Size = new Size(83, 22);
        FactChecingEnabled_RadioButton.TabIndex = 0;
        FactChecingEnabled_RadioButton.Text = "Enabled";
        FactChecingEnabled_RadioButton.UseVisualStyleBackColor = true;
        FactChecingEnabled_RadioButton.CheckedChanged += FactChecingEnabled_RadioButton_CheckedChanged;
        // 
        // groupBox8
        // 
        groupBox8.Controls.Add(OllamaModelName_TextBox);
        groupBox8.Controls.Add(label1);
        groupBox8.Location = new Point(11, 25);
        groupBox8.Name = "groupBox8";
        groupBox8.Size = new Size(262, 98);
        groupBox8.TabIndex = 36;
        groupBox8.TabStop = false;
        groupBox8.Text = "Identity";
        // 
        // OllamaModelName_TextBox
        // 
        OllamaModelName_TextBox.BorderStyle = BorderStyle.FixedSingle;
        OllamaModelName_TextBox.Location = new Point(33, 47);
        OllamaModelName_TextBox.Name = "OllamaModelName_TextBox";
        OllamaModelName_TextBox.Size = new Size(195, 26);
        OllamaModelName_TextBox.TabIndex = 35;
        OllamaModelName_TextBox.Text = "Ollama";
        OllamaModelName_TextBox.TextChanged += OllamaModelName_TextBox_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(33, 26);
        label1.Name = "label1";
        label1.Size = new Size(52, 18);
        label1.TabIndex = 34;
        label1.Text = "Name";
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(OllamaModel_Label);
        groupBox7.Controls.Add(OllamaModel_ComboBox);
        groupBox7.Location = new Point(279, 26);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new Size(262, 98);
        groupBox7.TabIndex = 35;
        groupBox7.TabStop = false;
        groupBox7.Text = "Model Selection";
        // 
        // OllamaModel_Label
        // 
        OllamaModel_Label.AutoSize = true;
        OllamaModel_Label.Location = new Point(31, 26);
        OllamaModel_Label.Name = "OllamaModel_Label";
        OllamaModel_Label.Size = new Size(110, 18);
        OllamaModel_Label.TabIndex = 34;
        OllamaModel_Label.Text = "Ollama model";
        // 
        // OllamaModel_ComboBox
        // 
        OllamaModel_ComboBox.FormattingEnabled = true;
        OllamaModel_ComboBox.Location = new Point(31, 47);
        OllamaModel_ComboBox.Name = "OllamaModel_ComboBox";
        OllamaModel_ComboBox.Size = new Size(200, 26);
        OllamaModel_ComboBox.TabIndex = 33;
        OllamaModel_ComboBox.SelectedIndexChanged += Personality_ComboBoxes_SelectedIndexChanged;
        // 
        // Configuration_SaveFileDialog
        // 
        Configuration_SaveFileDialog.DefaultExt = "configuration";
        Configuration_SaveFileDialog.FileName = "Configuration";
        Configuration_SaveFileDialog.Filter = "Configurations (*.configuration)|*.configuration";
        // 
        // MainForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(1584, 861);
        Controls.Add(Ollama_Label);
        Controls.Add(Get_Response_Button);
        Controls.Add(Get_Response_TextBox);
        Controls.Add(Ollama_TextBox);
        Controls.Add(groupBox6);
        DoubleBuffered = true;
        Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximumSize = new Size(1600, 900);
        Name = "MainForm";
        Text = "Ollamas Unplugged - Personality";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        groupBox6.ResumeLayout(false);
        groupBox10.ResumeLayout(false);
        groupBox10.PerformLayout();
        groupBox9.ResumeLayout(false);
        groupBox9.PerformLayout();
        groupBox8.ResumeLayout(false);
        groupBox8.PerformLayout();
        groupBox7.ResumeLayout(false);
        groupBox7.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label Ollama_Label;
    private Label ConversationStyle_Label;
    private Label label2;
    private Label FieldOfExpertise_Label;
    private Label DetailLevel_label;
    private Label Language_Label;
    private Label Gender_Label;
    private Label PolitenessLevel_Label;
    private Label Personality_Label;
    private Label Role_Label;
    private Label ResponseLength_Label;
    private Label Tone_Label;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox6;
    private Label OllamaModel_Label;
    private GroupBox groupBox7;
    private GroupBox groupBox8;
    private Label label1;
    private GroupBox groupBox9;
    public ComboBox ConversationStyle_ComboBox;
    public ComboBox CreativityLevel_ComboBox;
    public ComboBox FieldOfExpertise_ComboBox;
    public ComboBox DetailLevel_ComboBox;
    public ComboBox Language_ComboBox;
    public ComboBox Gender_ComboBox;
    public ComboBox PolitenessLevel_ComboBox;
    public ComboBox Personality_ComboBox;
    public ComboBox Role_ComboBox;
    public ComboBox ResponseLength_ComboBox;
    public ComboBox Tone_ComboBox;
    public ComboBox OllamaModel_ComboBox;
    public TextBox OllamaModelName_TextBox;
    public RadioButton FactChecingDisabled_RadioButton;
    public RadioButton FactChecingEnabled_RadioButton;
    public RichTextBox Ollama_TextBox;
    public RichTextBox Get_Response_TextBox;
    public Button Get_Response_Button;
    private GroupBox groupBox10;
    private Label label3;
    public ComboBox OllamaModelConfigurations_ComboBox;
    private SaveFileDialog Configuration_SaveFileDialog;
    private Button SaveConfiguration_Button;
}

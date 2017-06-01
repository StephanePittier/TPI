namespace ConvertisseurNumerique
{
    partial class FormConverter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertButton = new System.Windows.Forms.Button();
            this.decimalLabel = new System.Windows.Forms.Label();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.hexaLabel = new System.Windows.Forms.Label();
            this.octalLabel = new System.Windows.Forms.Label();
            this.bcdLabel = new System.Windows.Forms.Label();
            this.grayLabel = new System.Windows.Forms.Label();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.decimalTextBox = new System.Windows.Forms.TextBox();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.octalTextBox = new System.Windows.Forms.TextBox();
            this.hexaTextBox = new System.Windows.Forms.TextBox();
            this.bcdTextBox = new System.Windows.Forms.TextBox();
            this.grayTextBox = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.typesLabel = new System.Windows.Forms.Label();
            this.userValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(366, 42);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "convertir";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // decimalLabel
            // 
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Location = new System.Drawing.Point(12, 115);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(45, 13);
            this.decimalLabel.TabIndex = 1;
            this.decimalLabel.Text = "Décimal";
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Location = new System.Drawing.Point(18, 170);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(39, 13);
            this.binaryLabel.TabIndex = 2;
            this.binaryLabel.Text = "Binaire";
            // 
            // hexaLabel
            // 
            this.hexaLabel.AutoSize = true;
            this.hexaLabel.Location = new System.Drawing.Point(186, 170);
            this.hexaLabel.Name = "hexaLabel";
            this.hexaLabel.Size = new System.Drawing.Size(68, 13);
            this.hexaLabel.TabIndex = 3;
            this.hexaLabel.Text = "Hexadécimal";
            // 
            // octalLabel
            // 
            this.octalLabel.AutoSize = true;
            this.octalLabel.Location = new System.Drawing.Point(222, 115);
            this.octalLabel.Name = "octalLabel";
            this.octalLabel.Size = new System.Drawing.Size(32, 13);
            this.octalLabel.TabIndex = 4;
            this.octalLabel.Text = "Octal";
            // 
            // bcdLabel
            // 
            this.bcdLabel.AutoSize = true;
            this.bcdLabel.Location = new System.Drawing.Point(401, 115);
            this.bcdLabel.Name = "bcdLabel";
            this.bcdLabel.Size = new System.Drawing.Size(57, 13);
            this.bcdLabel.TabIndex = 5;
            this.bcdLabel.Text = "Code BCD";
            // 
            // grayLabel
            // 
            this.grayLabel.AutoSize = true;
            this.grayLabel.Location = new System.Drawing.Point(393, 170);
            this.grayLabel.Name = "grayLabel";
            this.grayLabel.Size = new System.Drawing.Size(65, 13);
            this.grayLabel.TabIndex = 6;
            this.grayLabel.Text = "Code GRAY";
            // 
            // typesComboBox
            // 
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Items.AddRange(new object[] {
            "Décimal | 10",
            "Binaire | 2",
            "Octal | 8",
            "Hexadécimal | 16",
            "Code BCD",
            "Code GRAY"});
            this.typesComboBox.Location = new System.Drawing.Point(16, 44);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(121, 21);
            this.typesComboBox.TabIndex = 7;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(143, 44);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(217, 20);
            this.valueTextBox.TabIndex = 8;
            // 
            // decimalTextBox
            // 
            this.decimalTextBox.Enabled = false;
            this.decimalTextBox.Location = new System.Drawing.Point(63, 112);
            this.decimalTextBox.Name = "decimalTextBox";
            this.decimalTextBox.Size = new System.Drawing.Size(100, 20);
            this.decimalTextBox.TabIndex = 9;
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Enabled = false;
            this.binaryTextBox.Location = new System.Drawing.Point(63, 167);
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.binaryTextBox.TabIndex = 10;
            // 
            // octalTextBox
            // 
            this.octalTextBox.Enabled = false;
            this.octalTextBox.Location = new System.Drawing.Point(260, 112);
            this.octalTextBox.Name = "octalTextBox";
            this.octalTextBox.Size = new System.Drawing.Size(100, 20);
            this.octalTextBox.TabIndex = 11;
            // 
            // hexaTextBox
            // 
            this.hexaTextBox.Enabled = false;
            this.hexaTextBox.Location = new System.Drawing.Point(260, 167);
            this.hexaTextBox.Name = "hexaTextBox";
            this.hexaTextBox.Size = new System.Drawing.Size(100, 20);
            this.hexaTextBox.TabIndex = 12;
            // 
            // bcdTextBox
            // 
            this.bcdTextBox.Enabled = false;
            this.bcdTextBox.Location = new System.Drawing.Point(464, 112);
            this.bcdTextBox.Name = "bcdTextBox";
            this.bcdTextBox.Size = new System.Drawing.Size(100, 20);
            this.bcdTextBox.TabIndex = 13;
            // 
            // grayTextBox
            // 
            this.grayTextBox.Enabled = false;
            this.grayTextBox.Location = new System.Drawing.Point(464, 167);
            this.grayTextBox.Name = "grayTextBox";
            this.grayTextBox.Size = new System.Drawing.Size(100, 20);
            this.grayTextBox.TabIndex = 14;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(518, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 15;
            this.helpButton.Text = "Aide ?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // calculatorButton
            // 
            this.calculatorButton.Location = new System.Drawing.Point(518, 41);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(75, 23);
            this.calculatorButton.TabIndex = 16;
            this.calculatorButton.Text = "opérations";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // typesLabel
            // 
            this.typesLabel.AutoSize = true;
            this.typesLabel.Location = new System.Drawing.Point(15, 25);
            this.typesLabel.Name = "typesLabel";
            this.typesLabel.Size = new System.Drawing.Size(37, 13);
            this.typesLabel.TabIndex = 17;
            this.typesLabel.Text = "Type :";
            // 
            // userValueLabel
            // 
            this.userValueLabel.AutoSize = true;
            this.userValueLabel.Location = new System.Drawing.Point(140, 25);
            this.userValueLabel.Name = "userValueLabel";
            this.userValueLabel.Size = new System.Drawing.Size(89, 13);
            this.userValueLabel.TabIndex = 18;
            this.userValueLabel.Text = "valeur utilisateur :";
            // 
            // FormConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 215);
            this.Controls.Add(this.userValueLabel);
            this.Controls.Add(this.typesLabel);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.grayTextBox);
            this.Controls.Add(this.bcdTextBox);
            this.Controls.Add(this.hexaTextBox);
            this.Controls.Add(this.octalTextBox);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.decimalTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.typesComboBox);
            this.Controls.Add(this.grayLabel);
            this.Controls.Add(this.bcdLabel);
            this.Controls.Add(this.octalLabel);
            this.Controls.Add(this.hexaLabel);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.convertButton);
            this.Name = "FormConverter";
            this.Text = "Convertisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.Label hexaLabel;
        private System.Windows.Forms.Label octalLabel;
        private System.Windows.Forms.Label bcdLabel;
        private System.Windows.Forms.Label grayLabel;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox decimalTextBox;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.TextBox octalTextBox;
        private System.Windows.Forms.TextBox hexaTextBox;
        private System.Windows.Forms.TextBox bcdTextBox;
        private System.Windows.Forms.TextBox grayTextBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button calculatorButton;
        private System.Windows.Forms.Label typesLabel;
        private System.Windows.Forms.Label userValueLabel;
    }
}


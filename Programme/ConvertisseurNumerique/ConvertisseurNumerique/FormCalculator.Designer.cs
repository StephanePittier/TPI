namespace ConvertisseurNumerique
{
    partial class FormCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.type1ComboBox = new System.Windows.Forms.ComboBox();
            this.type2ComboBox = new System.Windows.Forms.ComboBox();
            this.value1TextBox = new System.Windows.Forms.TextBox();
            this.value2TextBox = new System.Windows.Forms.TextBox();
            this.operationsComboBox = new System.Windows.Forms.ComboBox();
            this.value1Label = new System.Windows.Forms.Label();
            this.value2Label = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // type1ComboBox
            // 
            this.type1ComboBox.FormattingEnabled = true;
            this.type1ComboBox.Items.AddRange(new object[] {
            "Décimal | 10",
            "Binaire | 2",
            "Octal | 8",
            "Hexadécimal | 16"});
            this.type1ComboBox.Location = new System.Drawing.Point(50, 60);
            this.type1ComboBox.Name = "type1ComboBox";
            this.type1ComboBox.Size = new System.Drawing.Size(110, 21);
            this.type1ComboBox.TabIndex = 0;
            // 
            // type2ComboBox
            // 
            this.type2ComboBox.FormattingEnabled = true;
            this.type2ComboBox.Items.AddRange(new object[] {
            "Décimal | 10",
            "Binaire | 2",
            "Octal | 8",
            "Hexadécimal | 16"});
            this.type2ComboBox.Location = new System.Drawing.Point(50, 180);
            this.type2ComboBox.Name = "type2ComboBox";
            this.type2ComboBox.Size = new System.Drawing.Size(110, 21);
            this.type2ComboBox.TabIndex = 1;
            // 
            // value1TextBox
            // 
            this.value1TextBox.Location = new System.Drawing.Point(163, 60);
            this.value1TextBox.Name = "value1TextBox";
            this.value1TextBox.Size = new System.Drawing.Size(100, 20);
            this.value1TextBox.TabIndex = 2;
            // 
            // value2TextBox
            // 
            this.value2TextBox.Location = new System.Drawing.Point(163, 180);
            this.value2TextBox.Name = "value2TextBox";
            this.value2TextBox.Size = new System.Drawing.Size(100, 20);
            this.value2TextBox.TabIndex = 3;
            // 
            // operationsComboBox
            // 
            this.operationsComboBox.FormattingEnabled = true;
            this.operationsComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationsComboBox.Location = new System.Drawing.Point(100, 117);
            this.operationsComboBox.Name = "operationsComboBox";
            this.operationsComboBox.Size = new System.Drawing.Size(100, 21);
            this.operationsComboBox.TabIndex = 4;
            // 
            // value1Label
            // 
            this.value1Label.AutoSize = true;
            this.value1Label.Location = new System.Drawing.Point(5, 65);
            this.value1Label.Name = "value1Label";
            this.value1Label.Size = new System.Drawing.Size(46, 13);
            this.value1Label.TabIndex = 5;
            this.value1Label.Text = "Valeur 1";
            // 
            // value2Label
            // 
            this.value2Label.AutoSize = true;
            this.value2Label.Location = new System.Drawing.Point(5, 185);
            this.value2Label.Name = "value2Label";
            this.value2Label.Size = new System.Drawing.Size(46, 13);
            this.value2Label.TabIndex = 6;
            this.value2Label.Text = "Valeur 2";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(100, 217);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculer";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.Location = new System.Drawing.Point(12, 246);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(276, 292);
            this.resultPanel.TabIndex = 8;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 550);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.value2Label);
            this.Controls.Add(this.value1Label);
            this.Controls.Add(this.operationsComboBox);
            this.Controls.Add(this.value2TextBox);
            this.Controls.Add(this.value1TextBox);
            this.Controls.Add(this.type2ComboBox);
            this.Controls.Add(this.type1ComboBox);
            this.Name = "FormCalculator";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type1ComboBox;
        private System.Windows.Forms.ComboBox type2ComboBox;
        private System.Windows.Forms.TextBox value1TextBox;
        private System.Windows.Forms.TextBox value2TextBox;
        private System.Windows.Forms.ComboBox operationsComboBox;
        private System.Windows.Forms.Label value1Label;
        private System.Windows.Forms.Label value2Label;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel resultPanel;
    }
}
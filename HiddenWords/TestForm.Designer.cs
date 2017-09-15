namespace HiddenWords
{
    partial class TestForm
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(43, 65);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 23);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert to Hex";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.convertButton_click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(43, 39);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(43, 95);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 2;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 146);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ConvertButton);
            this.Name = "TestForm";
            this.Text = "Testform of suffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label outputLabel;
    }
}


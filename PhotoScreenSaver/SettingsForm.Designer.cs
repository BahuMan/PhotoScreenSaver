namespace PhotoScreenSaver
{
    partial class SettingsForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Attribution = new System.Windows.Forms.Label();
            this.textToDisplay = new System.Windows.Forms.TextBox();
            this.textToDisplayLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(40, 54);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(258, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "PhotoScreenSaver";
            // 
            // Attribution
            // 
            this.Attribution.AutoSize = true;
            this.Attribution.Location = new System.Drawing.Point(46, 89);
            this.Attribution.Name = "Attribution";
            this.Attribution.Size = new System.Drawing.Size(103, 13);
            this.Attribution.TabIndex = 1;
            this.Attribution.Text = "by Bart Huylebroeck";
            // 
            // textToDisplay
            // 
            this.textToDisplay.Location = new System.Drawing.Point(46, 148);
            this.textToDisplay.Name = "textToDisplay";
            this.textToDisplay.Size = new System.Drawing.Size(353, 20);
            this.textToDisplay.TabIndex = 2;
            // 
            // textToDisplayLabel
            // 
            this.textToDisplayLabel.AutoSize = true;
            this.textToDisplayLabel.Location = new System.Drawing.Point(46, 132);
            this.textToDisplayLabel.Name = "textToDisplayLabel";
            this.textToDisplayLabel.Size = new System.Drawing.Size(78, 13);
            this.textToDisplayLabel.TabIndex = 3;
            this.textToDisplayLabel.Text = "Text to display:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(248, 226);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(151, 34);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(46, 226);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(151, 34);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(451, 293);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textToDisplayLabel);
            this.Controls.Add(this.textToDisplay);
            this.Controls.Add(this.Attribution);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Attribution;
        private System.Windows.Forms.TextBox textToDisplay;
        private System.Windows.Forms.Label textToDisplayLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}
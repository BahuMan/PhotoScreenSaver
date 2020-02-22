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
            this.FolderName = new System.Windows.Forms.TextBox();
            this.FolderLabel = new System.Windows.Forms.Label();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.OKButton1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowseButton = new System.Windows.Forms.Button();
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
            // FolderName
            // 
            this.FolderName.Location = new System.Drawing.Point(46, 148);
            this.FolderName.Name = "FolderName";
            this.FolderName.Size = new System.Drawing.Size(314, 20);
            this.FolderName.TabIndex = 2;
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = true;
            this.FolderLabel.Location = new System.Drawing.Point(46, 132);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Size = new System.Drawing.Size(131, 13);
            this.FolderLabel.TabIndex = 3;
            this.FolderLabel.Text = "Folder containing pictures:";
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(248, 226);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(151, 34);
            this.CancelButton1.TabIndex = 4;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton1
            // 
            this.OKButton1.Location = new System.Drawing.Point(46, 226);
            this.OKButton1.Name = "OKButton1";
            this.OKButton1.Size = new System.Drawing.Size(151, 34);
            this.OKButton1.TabIndex = 4;
            this.OKButton1.Text = "OK";
            this.OKButton1.UseVisualStyleBackColor = true;
            this.OKButton1.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // folderBrowseButton
            // 
            this.folderBrowseButton.Location = new System.Drawing.Point(366, 148);
            this.folderBrowseButton.Name = "folderBrowseButton";
            this.folderBrowseButton.Size = new System.Drawing.Size(32, 20);
            this.folderBrowseButton.TabIndex = 5;
            this.folderBrowseButton.Text = "...";
            this.folderBrowseButton.UseVisualStyleBackColor = true;
            this.folderBrowseButton.Click += new System.EventHandler(this.folderBrowseButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(451, 293);
            this.Controls.Add(this.folderBrowseButton);
            this.Controls.Add(this.OKButton1);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.FolderLabel);
            this.Controls.Add(this.FolderName);
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
        private System.Windows.Forms.TextBox FolderName;
        private System.Windows.Forms.Label FolderLabel;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Button OKButton1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folderBrowseButton;
    }
}
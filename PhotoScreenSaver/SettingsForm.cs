using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace PhotoScreenSaver
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        public const string REG_FOLDER_NAME = "FolderName";

        private void SaveSettings()
        {
            // Create or get existing Registry subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bart_ScreenSaver");

            key.SetValue(REG_FOLDER_NAME, FolderName.Text);
        }

        private void LoadSettings()
        {
            // Get the value stored in the Registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Bart_ScreenSaver");
            if (key == null)
                FolderName.Text = "C# Screen Saver";
            else
                FolderName.Text = (string)key.GetValue(REG_FOLDER_NAME);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void folderBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult folderResult = folderBrowserDialog1.ShowDialog();
            if (folderResult == DialogResult.OK)
            {
                FolderName.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}

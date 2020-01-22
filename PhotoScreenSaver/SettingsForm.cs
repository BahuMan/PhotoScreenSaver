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


        private void SaveSettings()
        {
            // Create or get existing Registry subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bart_ScreenSaver");

            key.SetValue("text", textToDisplay.Text);
        }

        private void LoadSettings()
        {
            // Get the value stored in the Registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Bart_ScreenSaver");
            if (key == null)
                textToDisplay.Text = "C# Screen Saver";
            else
                textToDisplay.Text = (string)key.GetValue("text");
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
    }
}

using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhotoScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        public ScreenSaverForm()
        {
            InitializeComponent();
        }

        private bool previewMode = false;
        private float aspectRatio = 1.0f; //width:height
        private string pictureFolder = ".";
        private string[] PictureFiles;

        //constructor gets used in default, full-screen mode
        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        //constructor gets used when running in preview mode
        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            previewMode = true;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

            this.aspectRatio = Bounds.Width / Bounds.Height;
            //moveTimer.Interval = 1000;
            //moveTimer.Tick += new EventHandler(MoveTimer_Tick);
            //moveTimer.Start();

            
            // Use the string from the Registry if it exists
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Bart_ScreenSaver");

            if (key != null)
                pictureFolder = (string)key.GetValue(SettingsForm.REG_FOLDER_NAME);

            PictureFiles = Directory.GetFiles(pictureFolder, "*.jpg", SearchOption.AllDirectories);
            pictureBox1.Image = Image.FromFile(PictureFiles[0]);
            pictureBox2.Image = Image.FromFile(PictureFiles[1]);
            pictureBox3.Image = Image.FromFile(PictureFiles[2]);
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private Point mouseLocation;
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    // Terminate if mouse is moved a significant distance
                    if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                        Math.Abs(mouseLocation.Y - e.Y) > 5)
                        Application.Exit();
                }

                // Update current mouse location
                mouseLocation = e.Location;
            }
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private Random rand = new Random();
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            // Move text to new location
            //ourTextLabel.Left = rand.Next(Math.Max(1, Bounds.Width - ourTextLabel.Width));
            //ourTextLabel.Top = rand.Next(Math.Max(1, Bounds.Height - ourTextLabel.Height));
        }
    }
}

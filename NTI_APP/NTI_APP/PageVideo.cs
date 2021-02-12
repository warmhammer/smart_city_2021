using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace NTI_APP
{
    public partial class PageVideo : UserControl
    {
        public PageVideo(System.Diagnostics.Process factoryIOProcess)
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var hwnd = factoryIOProcess.MainWindowHandle;
            //GetWindowRect(hwnd, out var rect);
            
            Bitmap image = new Bitmap(900, 600);
            
            Graphics.FromImage(image).CopyFromScreen(900, 600, 0, 0, new Size(900, 600), CopyPixelOperation.SourceCopy);
        }
    }
}

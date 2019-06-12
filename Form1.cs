using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPaletteGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void BtnSingleImage_Click(object sender, EventArgs e)
        {
            List<Color> pixelList = new List<Color>();
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                var t = new Thread(() => pixelRead(dialog));
                t.Start();
                lblStatus.Text = "Loading...";
            }          
        }

        public void pixelRead(OpenFileDialog dialog) {
            List<Color> pixelList = new List<Color>();

            Bitmap img = new Bitmap(dialog.FileName);

            progressBar1.Maximum = img.Width;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (!pixelList.Contains(pixel))
                    {
                        pixelList.Add(pixel);
                    }
                }

                progressBar1.Value += 1;
            }

            progressBar1.Value = progressBar1.Maximum;

            lblPixelCount.Text = $"Pixel Count: {pixelList.Count}";
            lblStatus.Text = "Done";

            btnDownload.Enabled = true;
        }
    }
}

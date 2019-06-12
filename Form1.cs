using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPaletteGenerator
{
    public partial class Form1 : Form
    {
        List<Color> pixelList;
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
            pixelList = new List<Color>();

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

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            IronPdf.HtmlToPdf render = new IronPdf.HtmlToPdf();

            string htmlString = "<div style=\"padding: 5px;\">";

            int count = 0;

            foreach (Color color in pixelList) {
                count += 1;
                if (count < 20)
                {
                    htmlString += "<li style=\"float: left; \">";
                    htmlString += $"<div style=\"display: flex; margin: 3px; width: 50px; height: 50px; background: rgba({color.R}, {color.G}, {color.B}, {color.A}) ;\"></div>";
                    htmlString += "</li>";
                }
                else {
                    htmlString += "<p style=\"page -break-before: always\">";
                    htmlString += "<li style=\"float: left; \">";
                    htmlString += $"<div style=\"display: flex; margin: 3px; width: 50px; height: 50px; background: rgba({color.R}, {color.G}, {color.B}, {color.A}) ;\"></div>";
                    htmlString += "</li>";
                    count = 0;
                }

            }

            htmlString += "</div>";

            lblStatus.Text = "Rendering PDF...";

            render.RenderHtmlAsPdf(htmlString).SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/palette.pdf");

            lblStatus.Text = "Saved!";

            MessageBox.Show("File Saved to Desktop");

        }
    }
}

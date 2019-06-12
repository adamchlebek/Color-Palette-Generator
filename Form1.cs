﻿using System;
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
        private string folderPath;

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
                folderPath = Path.GetDirectoryName(dialog.FileName);

                var t = new Thread(() => pixelRead(dialog));
                t.Start();
                lblStatus.Text = "Loading...";
            }          
        }

        public void pixelRead(OpenFileDialog dialog) {
            pixelList = new List<Color>();

            Bitmap img = new Bitmap(dialog.FileName);
            int pixelCount = 0;

            progressBar1.Maximum = img.Width;

            pixelCount += img.Width + img.Height;

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

            lblTotalPixelCount.Text = $"Pixel Count: {pixelCount}";
            lblPixelCount.Text = $"Pixel Count: {pixelList.Count}";
            lblStatus.Text = "Done";

            btnDownload.Enabled = true;
            btnSingleImage.Enabled = false;
            btnFolder.Enabled = false;
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            string htmlString = "<div style=\"padding: 5px;\">";

            int count = 0;

            foreach (Color color in pixelList) {
                count += 1;
                if (count < 280)
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
            Application.DoEvents();

            RenderPdfAsync(htmlString);
        }

        private void RenderPdfAsync(string htmlString)
        {
            IronPdf.HtmlToPdf render = new IronPdf.HtmlToPdf();

            
            lblStatus.Text = "Saved!";

            render.RenderHtmlAsPdf(htmlString).SaveAs(folderPath + "/palette.pdf");

            MessageBox.Show("File Saved to " + folderPath);

            pixelList = new List<Color>();
            btnDownload.Enabled = false;
            btnSingleImage.Enabled = true;
            btnFolder.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            List<Color> pixelList = new List<Color>();

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var t = new Thread(() => pixelReadFolder(fbd));
                    t.Start();
                    lblStatus.Text = "Loading...";
                }
            }
        }

        public void pixelReadFolder(FolderBrowserDialog result)
        {
            folderPath = Path.GetFullPath(result.SelectedPath);

            pixelList = new List<Color>();
            int pixelCount = 0;

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".PNG" };

            var files = Directory
                .GetFiles(result.SelectedPath)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                .ToList();

            progressBar1.Maximum = 0;

            foreach (var file in files)
            {
                Bitmap img = new Bitmap(file);

                progressBar1.Maximum += img.Width;
            }

            foreach (var file in files)
            {
                Bitmap img = new Bitmap(file);

                pixelCount += img.Width + img.Height;

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
            }

            progressBar1.Value = progressBar1.Maximum;
            
            lblTotalPixelCount.Text = $"Pixel Count: {pixelCount}";
            lblPixelCount.Text = $"Different Pixel Count: {pixelList.Count}";
            lblStatus.Text = "Done";
            
            btnDownload.Enabled = true;
            btnSingleImage.Enabled = false;
            btnFolder.Enabled = false;
        }
    }
}

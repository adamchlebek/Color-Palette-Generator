namespace ColorPaletteGenerator
{
    partial class Form1
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
            this.btnSingleImage = new System.Windows.Forms.Button();
            this.btnMultipleImages = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPixelCount = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSingleImage
            // 
            this.btnSingleImage.Location = new System.Drawing.Point(13, 13);
            this.btnSingleImage.Name = "btnSingleImage";
            this.btnSingleImage.Size = new System.Drawing.Size(775, 67);
            this.btnSingleImage.TabIndex = 0;
            this.btnSingleImage.Text = "Upload Single Image";
            this.btnSingleImage.UseVisualStyleBackColor = true;
            this.btnSingleImage.Click += new System.EventHandler(this.BtnSingleImage_Click);
            // 
            // btnMultipleImages
            // 
            this.btnMultipleImages.Location = new System.Drawing.Point(12, 86);
            this.btnMultipleImages.Name = "btnMultipleImages";
            this.btnMultipleImages.Size = new System.Drawing.Size(775, 67);
            this.btnMultipleImages.TabIndex = 1;
            this.btnMultipleImages.Text = "Upload Multiple Image";
            this.btnMultipleImages.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(13, 343);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(774, 95);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(375, 249);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(774, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lblPixelCount
            // 
            this.lblPixelCount.AutoSize = true;
            this.lblPixelCount.Location = new System.Drawing.Point(12, 327);
            this.lblPixelCount.Name = "lblPixelCount";
            this.lblPixelCount.Size = new System.Drawing.Size(66, 13);
            this.lblPixelCount.TabIndex = 5;
            this.lblPixelCount.Text = "Pixel Count: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPixelCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnMultipleImages);
            this.Controls.Add(this.btnSingleImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingleImage;
        private System.Windows.Forms.Button btnMultipleImages;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPixelCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


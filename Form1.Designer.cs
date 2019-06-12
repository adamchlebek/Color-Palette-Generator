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
            this.btnDownload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPixelCount = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSingleImage = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.lblTotalPixelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(17, 422);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(1032, 117);
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
            this.lblStatus.Location = new System.Drawing.Point(500, 306);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 17);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 274);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1032, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // lblPixelCount
            // 
            this.lblPixelCount.AutoSize = true;
            this.lblPixelCount.Location = new System.Drawing.Point(16, 402);
            this.lblPixelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPixelCount.Name = "lblPixelCount";
            this.lblPixelCount.Size = new System.Drawing.Size(144, 17);
            this.lblPixelCount.TabIndex = 5;
            this.lblPixelCount.Text = "Different Pixel Count: ";
            // 
            // btnSingleImage
            // 
            this.btnSingleImage.Location = new System.Drawing.Point(17, 16);
            this.btnSingleImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSingleImage.Name = "btnSingleImage";
            this.btnSingleImage.Size = new System.Drawing.Size(1033, 82);
            this.btnSingleImage.TabIndex = 0;
            this.btnSingleImage.Text = "Upload Single Image";
            this.btnSingleImage.UseVisualStyleBackColor = true;
            this.btnSingleImage.Click += new System.EventHandler(this.BtnSingleImage_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(17, 106);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(1033, 82);
            this.btnFolder.TabIndex = 6;
            this.btnFolder.Text = "Upload Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // lblTotalPixelCount
            // 
            this.lblTotalPixelCount.AutoSize = true;
            this.lblTotalPixelCount.Location = new System.Drawing.Point(16, 381);
            this.lblTotalPixelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPixelCount.Name = "lblTotalPixelCount";
            this.lblTotalPixelCount.Size = new System.Drawing.Size(86, 17);
            this.lblTotalPixelCount.TabIndex = 7;
            this.lblTotalPixelCount.Text = "Pixel Count: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTotalPixelCount);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lblPixelCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSingleImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPixelCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSingleImage;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label lblTotalPixelCount;
    }
}


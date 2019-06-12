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
            this.btnDownload.Location = new System.Drawing.Point(13, 343);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(774, 95);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnMultipleImages);
            this.Controls.Add(this.btnSingleImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleImage;
        private System.Windows.Forms.Button btnMultipleImages;
        private System.Windows.Forms.Button btnDownload;
    }
}


namespace Image_Gallery_forms
{
    partial class ImageGallery
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGallery));
            btnLoadImages = new Button();
            openFileDialog1 = new OpenFileDialog();
            flowPanel = new FlowLayoutPanel();
            pboxImages = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            btnRotate = new Button();
            lstboxImagesInfo = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pboxImages).BeginInit();
            SuspendLayout();
            // 
            // btnLoadImages
            // 
            btnLoadImages.Dock = DockStyle.Top;
            btnLoadImages.FlatStyle = FlatStyle.Flat;
            btnLoadImages.Location = new Point(0, 0);
            btnLoadImages.Name = "btnLoadImages";
            btnLoadImages.Size = new Size(784, 23);
            btnLoadImages.TabIndex = 0;
            btnLoadImages.Text = "Load";
            btnLoadImages.UseVisualStyleBackColor = true;
            btnLoadImages.Click += BtnLoadImages_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Dock = DockStyle.Bottom;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(0, 431);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(784, 130);
            flowPanel.TabIndex = 1;
            // 
            // pboxImages
            // 
            pboxImages.BorderStyle = BorderStyle.FixedSingle;
            pboxImages.Dock = DockStyle.Right;
            pboxImages.Location = new Point(219, 23);
            pboxImages.Name = "pboxImages";
            pboxImages.Size = new Size(565, 408);
            pboxImages.SizeMode = PictureBoxSizeMode.Zoom;
            pboxImages.TabIndex = 0;
            pboxImages.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(163, 76);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(50, 50);
            btnNext.TabIndex = 2;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(163, 132);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(50, 50);
            btnPrevious.TabIndex = 3;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnRotate
            // 
            btnRotate.FlatStyle = FlatStyle.Flat;
            btnRotate.Location = new Point(163, 188);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(50, 50);
            btnRotate.TabIndex = 4;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            // 
            // lstboxImagesInfo
            // 
            lstboxImagesInfo.BorderStyle = BorderStyle.FixedSingle;
            lstboxImagesInfo.Dock = DockStyle.Left;
            lstboxImagesInfo.FormattingEnabled = true;
            lstboxImagesInfo.ItemHeight = 15;
            lstboxImagesInfo.Location = new Point(0, 23);
            lstboxImagesInfo.Name = "lstboxImagesInfo";
            lstboxImagesInfo.Size = new Size(157, 408);
            lstboxImagesInfo.TabIndex = 5;
            lstboxImagesInfo.SelectedIndexChanged += lstboxImagesInfo_SelectedIndexChanged;
            // 
            // ImageGallery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(lstboxImagesInfo);
            Controls.Add(btnRotate);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pboxImages);
            Controls.Add(flowPanel);
            Controls.Add(btnLoadImages);
            Font = new Font("Arial", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ImageGallery";
            Text = "Image Gallery";
            ((System.ComponentModel.ISupportInitialize)pboxImages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadImages;
        private OpenFileDialog openFileDialog1;
        private FlowLayoutPanel flowPanel;
        private PictureBox pboxImages;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnRotate;
        private ListBox lstboxImagesInfo;
    }
}

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
            statusStrip1 = new StatusStrip();
            ImagePathStatus_lbl = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pboxImages).BeginInit();
            statusStrip1.SuspendLayout();
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
            flowPanel.Location = new Point(0, 415);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(784, 124);
            flowPanel.TabIndex = 1;
            // 
            // pboxImages
            // 
            pboxImages.BorderStyle = BorderStyle.FixedSingle;
            pboxImages.Dock = DockStyle.Fill;
            pboxImages.Location = new Point(44, 23);
            pboxImages.Name = "pboxImages";
            pboxImages.Size = new Size(696, 392);
            pboxImages.SizeMode = PictureBoxSizeMode.Zoom;
            pboxImages.TabIndex = 0;
            pboxImages.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.Dock = DockStyle.Right;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(740, 23);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(44, 392);
            btnNext.TabIndex = 2;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Center;
            btnPrevious.Dock = DockStyle.Left;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(0, 23);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(44, 392);
            btnPrevious.TabIndex = 3;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ImagePathStatus_lbl });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // ImagePathStatus_lbl
            // 
            ImagePathStatus_lbl.Name = "ImagePathStatus_lbl";
            ImagePathStatus_lbl.Size = new Size(37, 17);
            ImagePathStatus_lbl.Text = "Path: ";
            // 
            // ImageGallery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pboxImages);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(flowPanel);
            Controls.Add(btnLoadImages);
            Controls.Add(statusStrip1);
            Font = new Font("Arial", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ImageGallery";
            Text = "Image Gallery";
            ((System.ComponentModel.ISupportInitialize)pboxImages).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadImages;
        private OpenFileDialog openFileDialog1;
        private FlowLayoutPanel flowPanel;
        private PictureBox pboxImages;
        private Button btnNext;
        private Button btnPrevious;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ImagePathStatus_lbl;
    }
}

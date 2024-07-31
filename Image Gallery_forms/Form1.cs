using System.Windows.Forms;

namespace Image_Gallery_forms
{
    public partial class ImageGallery : Form
    {
        private int _currentIndex = -1;

        public ImageGallery()
        {
            InitializeComponent();
        }

        private void BtnLoadImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadImages(ofd.FileNames);
                }
            }
        }

        private void LoadImages(string[] fileNames)
        {
            flowPanel.Controls.Clear();
            lstboxImagesInfo.Items.Clear();
            _currentIndex = -1;

            foreach (string fileName in fileNames)
            {
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(fileName);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Width = 100;
                pb.Height = 100;
                pb.Padding = new Padding(5);
                pb.Click += new EventHandler(Pb_Click);
                flowPanel.Controls.Add(pb);
                lstboxImagesInfo.Items.Add(fileName);
            }

            if (fileNames.Length > 0)
            {
                _currentIndex = 0;
                pboxImages.Image = Image.FromFile(fileNames[_currentIndex]);
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox? pb = sender as PictureBox;
            if (pb != null)
            {
                pboxImages.Image = pb.Image;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstboxImagesInfo.Items.Count > 0 && _currentIndex < lstboxImagesInfo.Items.Count - 1)
            {
                _currentIndex++;
                pboxImages.Image = Image.FromFile(lstboxImagesInfo.Items[_currentIndex].ToString());
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lstboxImagesInfo.Items.Count > 0 && _currentIndex > 0)
            {
                _currentIndex--;
                pboxImages.Image = Image.FromFile(lstboxImagesInfo.Items[_currentIndex].ToString());
            }
        }

        private void lstboxImagesInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxImagesInfo.SelectedIndex != -1)
            {
                string selectedFileName = lstboxImagesInfo.SelectedItem.ToString();
                pboxImages.Image = Image.FromFile(selectedFileName);
                _currentIndex = lstboxImagesInfo.SelectedIndex;
            }
        }
    }
}

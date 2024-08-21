using System.Windows.Forms;

namespace Image_Gallery_forms
{
    public partial class ImageGallery : Form
    {
        private int _currentIndex = -1;
        private readonly List<string> _imageList = [];

        public ImageGallery()
        {
            InitializeComponent();
        }

        private void BtnLoadImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new())
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
            _imageList.Clear();
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
                _imageList.Add(fileName);
            }

            if (fileNames.Length > 0)
            {
                _currentIndex = 0;
                pboxImages.Image = Image.FromFile(fileNames[_currentIndex]);
                ImagePathStatus_lbl.Text = _imageList[_currentIndex].ToString();
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox? pb = sender as PictureBox;
                if (pb != null)
                {
                    pboxImages.Image = pb.Image;
                    ImagePathStatus_lbl.Text = _imageList[_currentIndex].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_imageList.Count > 0 && _currentIndex < _imageList.Count - 1)
            {
                _currentIndex++;
                pboxImages.Image = Image.FromFile(_imageList[_currentIndex].ToString());
                ImagePathStatus_lbl.Text = _imageList[_currentIndex].ToString();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_imageList.Count > 0 && _currentIndex > 0)
            {
                _currentIndex--;
                pboxImages.Image = Image.FromFile(_imageList[_currentIndex].ToString());
                ImagePathStatus_lbl.Text = _imageList[_currentIndex].ToString();
            }
        }
    }
}

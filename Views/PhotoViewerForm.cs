using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MuseumCatalog.Views
{
    public partial class PhotoViewerForm : Form
    {
        public PhotoViewerForm(byte[] photoData, string title)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(title))
                this.Text = title;

            if (photoData != null && photoData.Length > 0)
            {
                try
                {
                    using MemoryStream ms = new(photoData);
                    picPhoto.Image = Image.FromStream(ms);
                }
                catch
                {
                    MessageBox.Show("Не удалось загрузить изображение.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PhotoViewerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}

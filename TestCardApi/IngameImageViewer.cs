using System;
using System.Windows.Forms;

namespace TestCardApi
{
    public partial class IngameImageViewer : Form
    {
        public IngameImageViewer()
        {
            InitializeComponent();
        }

        public void UpdateImage(CardData cardList)
        {
            Util.UpdatePictureBoxByUrl(cardList.ingame_image.default_language, IngameImagePictureBox);

            Util.UpdateFormSizeToPictureSize(this, IngameImagePictureBox);
        }

        private void IngameImageViewer_Load(object sender, EventArgs e)
        {

        }

        private void ClipboardSetImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(IngameImagePictureBox.Image);
        }
    }
}

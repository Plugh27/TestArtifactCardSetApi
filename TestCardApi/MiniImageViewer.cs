using System;
using System.Windows.Forms;

namespace TestCardApi
{
    public partial class MiniImageViewer : Form
    {
        public MiniImageViewer()
        {
            InitializeComponent();
        }

        public void UpdateImage(CardData cardList)
        {
            Util.UpdatePictureBoxByUrl(cardList.mini_image.default_language, MiniImagePictureBox);

            Util.UpdateFormSizeToPictureSize(this, MiniImagePictureBox);
        }

        private void MiniImageViewer_Load(object sender, EventArgs e)
        {

        }

        private void ClipboardSetImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(MiniImagePictureBox.Image);
        }

        private void Clipboard64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ResizeAndSetToClipboard(64, MiniImagePictureBox.Image);
        }

        private void Clipboard128ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ResizeAndSetToClipboard(128, MiniImagePictureBox.Image);
        }
    }
}

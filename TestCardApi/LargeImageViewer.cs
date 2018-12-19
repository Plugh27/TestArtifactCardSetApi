using System;
using System.Windows.Forms;

namespace TestCardApi
{
    public partial class LargeImageViewer : Form
    {
        public LargeImageViewer()
        {
            InitializeComponent();
        }

        public void UpdateImage(CardData cardList)
        {
            Util.UpdatePictureBoxByUrl(cardList.large_image.japanese, LargeImagePictureBox);

            Util.UpdateFormSizeToPictureSize(this, LargeImagePictureBox);
        }

        private void LargeImageViewer_Load(object sender, EventArgs e)
        {

        }

        private void ClipboardSetImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(LargeImagePictureBox.Image);
        }

        private void ClipBoardWidth180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ResizeAndSetToClipboard(180, LargeImagePictureBox.Image);
        }
    }
}

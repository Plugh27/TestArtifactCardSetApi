using System;
using System.Windows.Forms;

namespace TestCardApi
{
    public partial class CardDetailViewer : Form
    {
        public CardDetailViewer()
        {
            InitializeComponent();
        }

        private string GetCardInfo(CardData cardData)
        {
            return cardData.card_name.japanese + "/" + cardData.card_name.english;
        }

        public void UpdateCardDetail(CardData cardData)
        {
            CardNameTextBox.Text = cardData.card_name.japanese;

            CardInfoTextBox.Text = GetCardInfo(cardData);

            AttackTextBox.Text = cardData.attack.ToString();
            ArmorTextBox.Text= cardData.armor.ToString();
            HitPointsTextBox.Text = cardData.hit_points.ToString();
        }

        private void CardDetailViewer_Load(object sender, EventArgs e)
        {

        }

        private void CopyToClipboardCardNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(CardNameTextBox.Text);
            }
            catch
            {
                // TODO: テキストボックスのtextプロパティがnull
                // TODO: たまたまクリップボードがBUSY（SetText関数が適当にリトライしてくれる）
            }
        }

        private void CopyToClipboardCardInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(CardInfoTextBox.Text);
            }
            catch
            {
                // TODO: テキストボックスのtextプロパティがnull
                // TODO: たまたまクリップボードがBUSY（SetText関数が適当にリトライしてくれる）
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestCardApi
{
    public partial class ReferencesViewer : Form
    {
        public ReferencesViewer()
        {
            InitializeComponent();
        }

        // 親フォームから渡されるカードセット情報全体
        CardSet _fullCardSet;

        private List<CrossReferenceData> _crossReferenceDatas;

        private void UpdateList(CardData cardData)
        {
            // 参照しているカードの情報をリスト化する
            List<CardData> cardDataList = new List<CardData>();
            foreach (var reference in cardData.references)
            {
                CardData referenceData = _fullCardSet.card_list.FirstOrDefault(s => s.card_id == reference.card_id);
                cardDataList.Add(referenceData);
            }

            // 逆参照しているカードの情報をリスト化する
            CrossReferenceData usages = _crossReferenceDatas.First(s => s.CardId == cardData.card_id);
            foreach (var abc in usages.ReverseReferences)
            {
                CardData usageData = _fullCardSet.card_list.FirstOrDefault(s => s.card_id == abc);
                cardDataList.Add(usageData);
            }

            // リストに反映する
            SoleListView.SetObjects(cardDataList);
        }

        public void UpdateReferences(CardData cardData)
        {
            UpdateList(cardData);
        }

        private void ReferencesViewer_Load(object sender, EventArgs e)
        {
            SoleListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // リストビューはハイパーリンクを使用する
            SoleListView.UseHyperlinks = true;

            // リストビューはグループ化を使用しない
            SoleListView.ShowGroups = false;

            // リストビューの名前リスト
            List<string> nameList = new List<string>
            {
                "card_type",
                "base_card_id",
                "card_name",
                "notag_card_text"
            };

            // リストビューの幅リスト
            List<int> widthList = new List<int>
            {
                200,
                200,
                200,
                200
            };

            // リストビューのColumnを設定する
            Util.InitColumns(nameList, widthList, SoleListView);

            // 名称はハイパーリンクとして表示する
            Util.SetHyperlinkOfColumn(SoleListView, "card_name", true);

            SoleListView.HyperlinkClicked += SoleListView_HyperlinkClicked;
        }

        private void SoleListView_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
        {
            CardData cardList = (CardData)e.Item.RowObject;

            ((Form1)MdiParent).CallSelectCard(cardList);

            e.Handled = true;
        }

        public void RefreshByNewData(CardSet newCardSet)
        {
            _fullCardSet = newCardSet;

            // クロスリファレンスを作成する
            _crossReferenceDatas = new List<CrossReferenceData>();
            // カードIDの数だけエントリーを作る
            foreach (var cardData in _fullCardSet.card_list)
            {
                _crossReferenceDatas.Add(new CrossReferenceData(){CardId = cardData.card_id});
            }
            // 逆参照データを登録する
            foreach (var cardData in _fullCardSet.card_list)
            {
                foreach (var reference in cardData.references)
                {
                    CrossReferenceData usage = _crossReferenceDatas.First(s => s.CardId == reference.card_id);
                    usage.ReverseReferences.Add(cardData.card_id);
                }
            }
        }
    }
}

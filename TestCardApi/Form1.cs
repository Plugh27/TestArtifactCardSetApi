using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestCardApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // large_imageを表示する子フォーム
        LargeImageViewer _childLargeImageViewer;

        // mini_imageを表示する子フォーム
        MiniImageViewer _childMiniImageViewer;

        // ingame_imageを表示する子フォーム
        IngameImageViewer _childIngameImageViewer;

        // referenceを表示する子フォーム
        ReferencesViewer _childReferencesViewer;

        // カードの一覧を表示する子フォーム
        CardListViewer _childCardListViewer;

        // 選択されたカードの詳細を表示する子フォーム
        CardDetailViewer _childCardDetailViewer;

        // 選択中のカード
        SelectCard _selectCard;

        private List<Form> _childForms;
        private List<string> _childFormPropertyNames;

        private void GetUrlButton_Click(object sender, EventArgs e)
        {
            // カードセット00, 01のデータを取得する
            List<string> cardsetIdList = new List<string> {"00", "01"};
            List<ApiResponseData> apiResponseDataList = new List<ApiResponseData>();
            foreach(var cardsetId in cardsetIdList)
            {
                Util.GetCardsetData(cardsetId, out var apiResponseData);
                apiResponseDataList.Add(apiResponseData);
            }

            // 取得したカードセットのデータをまとめる
            CardSet mergeCardSet = new CardSet {card_list = new List<CardData>()};
            foreach(var apiResponseData in apiResponseDataList)
            {
                mergeCardSet.card_list.AddRange(apiResponseData.card_set.card_list);
            }

            // 一覧表示フォームを更新する
            _childCardListViewer.RefreshByNewData(mergeCardSet);
            // 参照一覧表示を更新する
            _childReferencesViewer.RefreshByNewData(mergeCardSet);
        }

        // 一覧表示フォームから呼び出される、カード選択
        public void CallSelectCard(CardData cardList)
        {
            _selectCard(cardList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _childLargeImageViewer = new LargeImageViewer();
            _childMiniImageViewer = new MiniImageViewer();
            _childIngameImageViewer = new IngameImageViewer();
            _childReferencesViewer = new ReferencesViewer();
            _childCardListViewer = new CardListViewer();
            _childCardDetailViewer = new CardDetailViewer();

            _childForms = new List<Form>()
            {
                _childLargeImageViewer,
                _childMiniImageViewer,
                _childIngameImageViewer,
                _childReferencesViewer,
                _childCardListViewer,
                _childCardDetailViewer
            };

            _childFormPropertyNames = new List<string>()
            {
                "LargeImageViewer",
                "MiniImageViewer",
                "IngameImageViewer",
                "ReferencesViewer",
                "CardListViewer",
                "CardDetailViewer"
            };

            // 子フォームを表示する
            foreach (var childForm in _childForms)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }

            // カードが選択された時の処理を登録する
            _selectCard = _childLargeImageViewer.UpdateImage;
            _selectCard += _childMiniImageViewer.UpdateImage;
            _selectCard += _childIngameImageViewer.UpdateImage;
            _selectCard += _childReferencesViewer.UpdateReferences;
            _selectCard += _childCardDetailViewer.UpdateCardDetail;

            // 子フォームのLocation, Sizeを復元する
            for (int i = 0; i < _childForms.Count; i++)
            {
                _childForms[i].Location = (Point) Properties.Settings.Default[_childFormPropertyNames[i] + "Location"];
                _childForms[i].Size = (Size) Properties.Settings.Default[_childFormPropertyNames[i] + "Size"];

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 子フォームのLocation, Sizeを保存する
            for (int i = 0; i < _childForms.Count; i++)
            {
                Properties.Settings.Default[_childFormPropertyNames[i] + "Location"] = _childForms[i].Location;
                Properties.Settings.Default[_childFormPropertyNames[i] + "Size"] = _childForms[i].Size;
            }

            Properties.Settings.Default.Save();
        }
    }
}

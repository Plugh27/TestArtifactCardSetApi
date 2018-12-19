using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TestCardApi
{
    public partial class CardListViewer : Form
    {
        public CardListViewer()
        {
            InitializeComponent();
        }

        // 親フォームから渡されるカードセット情報全体
        CardSet _fullCardSet;

        private void CardListViewer_Load(object sender, EventArgs e)
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
                "card_name",
                "sub_card_name",
                "mana_cost",
                "gold_cost",
                "sub_type",
                "notag_card_text",
                "card_id"
            };

            // リストビューの幅リスト
            List<int> widthList = new List<int>
            {
                90,
                150,
                150,
                30,
                30,
                50,
                800,
                100
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

            MakeShowCardDataList();

        }

        // フォームで指定されているフィルタ条件に従って、リストに表示するデータを決める
        private void MakeShowCardDataList()
        {
            if (_fullCardSet == null)
            {
                MessageBox.Show(@"カード情報を未取得です");
                return;
            }

            // リストに表示する分のカード情報のリスト
            List<CardData> showCardDataList = new List<CardData>();
            showCardDataList.AddRange(_fullCardSet.card_list);

            // 特定の色でフィルタする
            if (FilterSpecificColorCheckBox.Checked)
            {
                // 色のチェックボックスのリスト
                List<CheckBox> checkBoxList =
                    new List<CheckBox> {RedCheckBox, GreenCheckBox, BlueCheckBox, BlackCheckBox};

                // 色のプロパティ名のリスト
                List<PropertyInfo> propertyNameList = new List<PropertyInfo>
                {
                    typeof(CardData).GetProperty("is_red"),
                    typeof(CardData).GetProperty("is_green"),
                    typeof(CardData).GetProperty("is_blue"),
                    typeof(CardData).GetProperty("is_black")
                };

                // 表示対象の、色のプロパティ名のリストを作成する
                List<PropertyInfo> searchPropertyInfoList = new List<PropertyInfo>();
                for(int i = 0; i < checkBoxList.Count(); i++)
                {
                    if (checkBoxList[i].Checked)
                    {
                        searchPropertyInfoList.Add(propertyNameList[i]);
                    }
                }

                List<CardData> baseCardTypeList = new List<CardData>();
                baseCardTypeList.AddRange(showCardDataList);

                // 表示対象のカードタイプのリストを作成する
                showCardDataList.Clear();
                foreach (var search in searchPropertyInfoList)
                {
                    var temp = baseCardTypeList.Where(s => (bool)search.GetValue(s)).ToList();
                    showCardDataList.AddRange(temp);
                }
            }

            // 特定のカードタイプでフィルタする
            if (FilterSpecificCardTypeCheckBox.Checked)
            {
                // カードタイプのチェックボックスのリスト
                List<CheckBox> checkBoxList = new List<CheckBox>
                {
                    HeroCheckBox,
                    CreepCheckBox,
                    ImprovementCheckBox,
                    SpellCheckBox,
                    AbilityCheckBox,
                    ItemCheckBox,
                    PassiveAbilityCheckBox
                };

                // カードタイプのチェックボックスに対応する文字列
                List<string> typeList = new List<string>
                {
                    Util.TypeHero,
                    Util.TypeCreep,
                    Util.TypeImprovement,
                    Util.TypeSpell,
                    Util.TypeAbility,
                    Util.TypeItem,
                    Util.TypePassiveAbility
                };

                // 表示対象のカードタイプのリストを作成する
                List<string> searchList = new List<string>();
                for(int i = 0; i < checkBoxList.Count(); i++)
                {
                    if (checkBoxList[i].Checked)
                    {
                        searchList.Add(typeList[i]);
                    }
                }

                List<CardData> baseCardTypeList = new List<CardData>();
                baseCardTypeList.AddRange(showCardDataList);

                // 表示対象のカードタイプのリストを作成する
                showCardDataList.Clear();
                foreach(var search in searchList)
                {
                    var temp = baseCardTypeList.Where(s => s.card_type == search).ToList();
                    showCardDataList.AddRange(temp);
                }
            }

            SoleListView.SetObjects(showCardDataList);
        }

        private void FilterSpecificColorControl_CheckedChanged(object sender, EventArgs e)
        {
            MakeShowCardDataList();
        }

        private void FilterSpecificCardTypeControl_CheckedChanged(object sender, EventArgs e)
        {
            MakeShowCardDataList();
        }

        private void FilterMultiCardTypeControl_CheckedChanged(object sender, EventArgs e)
        {
            MakeShowCardDataList();
        }
    }
}

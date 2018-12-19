using System;
using BrightIdeasSoftware;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace TestCardApi
{
    delegate void SelectCard(CardData cardList);

    public class Util
    {
        public static readonly string TypeHero = "Hero";
        public static readonly string TypeCreep = "Creep";
        public static readonly string TypeImprovement = "Improvement";
        public static readonly string TypeSpell = "Spell";
        public static readonly string TypeAbility = "Ability";
        public static readonly string TypeItem = "Item";
        public static readonly string TypePassiveAbility = "Passive Ability";

        public static readonly string RefTypeIncludes = "includes";

        public static string GetCardSetInfo(string setId)
        {
            string url = "https://playartifact.com/cardset/" + setId + "/";

            WebClient wc = new WebClient();

            Stream st = wc.OpenRead(url);
            StreamReader sr = new StreamReader(st ?? throw new InvalidOperationException());

            string jsonCardSetInfo = sr.ReadToEnd();

            sr.Close();
            st.Close();

            return jsonCardSetInfo;
        }

        public static string GetCardSetDetailAndCardList(string jsonCardSetInfo)
        {
            dynamic infoObject = JsonConvert.DeserializeObject<dynamic>(jsonCardSetInfo);
            string cdnRoot = infoObject.cdn_root;
            string cardInfoUrl = infoObject.url;

            string url = cdnRoot + cardInfoUrl;

            WebClient cardClient = new WebClient();

            Stream st = cardClient.OpenRead(url);
            StreamReader sr = new StreamReader(st ?? throw new InvalidOperationException());

            string jsonCardSetDetailAndCardList = sr.ReadToEnd();

            sr.Close();
            st.Close();

            return jsonCardSetDetailAndCardList;
        }

        public static void UpdatePictureBoxByUrl(string targetUrl, PictureBox targetPictureBox)
        {
            // PassiveなどではNULLで来る
            if (targetUrl == null)
            {
                return;
            }

            // TODO: 非同期に対応するバージョンも作る
            // TODO: なんか後処理いらないのか確認する
            WebRequest requestPic = WebRequest.Create(targetUrl);
            WebResponse responsePic = requestPic.GetResponse();
            Image webImage = Image.FromStream(responsePic.GetResponseStream() ?? throw new InvalidOperationException());

            targetPictureBox.Height = webImage.Height;
            targetPictureBox.Width = webImage.Width;
            targetPictureBox.Image = webImage;
        }

        public static void UpdateFormSizeToPictureSize(Form targetForm, PictureBox targetPictureBox)
        {
            targetForm.ClientSize = new Size(targetPictureBox.Size.Width, targetPictureBox.Size.Height);
        }

        public static void GetCardsetData(string cardsetId, out ApiResponseData apiResponseData)
        {
            // カードセットの情報（URL）を取得する
            string jsonCardSetInfo = GetCardSetInfo(cardsetId);
            // カードセットの内容を取得する
            string jsonCardSetDetailAndCardList = GetCardSetDetailAndCardList(jsonCardSetInfo);
            // カードセットのJSONデータをドットネットのクラスに変換する
            ApiResponseData cardSet = JsonConvert.DeserializeObject<ApiResponseData>(jsonCardSetDetailAndCardList);

            apiResponseData = cardSet;
        }

        /// <summary>
        /// ObjectListViewのColumnの初期設定を行う。
        /// </summary>
        /// <param name="nameList">名称のリスト</param>
        /// <param name="widthList">幅のリスト</param>
        /// <param name="objectListView">処理対象のObjectListView</param>
        public static void InitColumns(List<string> nameList, List<int> widthList, ObjectListView objectListView)
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                // ReSharper disable once UseObjectOrCollectionInitializer
                OLVColumn columnHeader = new OLVColumn();
                columnHeader.Text = nameList[i];
                columnHeader.AspectName = nameList[i];
                columnHeader.Width = widthList[i];
                objectListView.AllColumns.Add(columnHeader);
                objectListView.Columns.Add(columnHeader);
            }
        }

        /// <summary>
        /// AspectNameを元にHyperLinkの設定を行う
        /// </summary>
        /// <param name="objectListView">処理対象のObjectListView</param>
        /// <param name="aspectName">設定対象のカラムのAspectName</param>
        /// <param name="isHyperLink">設定するHyperLinkのブール値</param>
        public static void SetHyperlinkOfColumn(ObjectListView objectListView, string aspectName, bool isHyperLink)
        {
            var column = objectListView.AllColumns.FirstOrDefault(s => s.AspectName.Equals(aspectName));
            if (column == null)
            {
                //Log.Error($"SetHyperlinkOfColumn カラムが見つからない。aspectName: {aspectName}");
            }
            else
            {
                column.Hyperlink = isHyperLink;
            }
        }

        public static void ResizeAndSetToClipboard(int width, Image image)
        {
            Size baseSize = image.Size;

            int resizeWidth = width;
            int resizeHeight = (int)(baseSize.Height * (double)resizeWidth / baseSize.Width);

            Bitmap resizeBmp = new Bitmap(resizeWidth, resizeHeight);
            Graphics g = Graphics.FromImage(resizeBmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, resizeWidth, resizeHeight);

            Clipboard.SetImage(resizeBmp);
        }
    }
}

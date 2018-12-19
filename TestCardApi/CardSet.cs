using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// JSONの要素に対応させるので、命名規則のチェックを切る
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace TestCardApi
{
    public class Name
    {
        public string english { get; set; }
        public string japanese { get; set; }

        public override string ToString()
        {
            return japanese;
        }
    }

    public class CardName
    {
        public string english { get; set; }
        public string japanese { get; set; }

        public override string ToString()
        {
            return japanese;
        }
    }

    public class CardText
    {
        public string english { get; set; } = "";
        public string japanese { get; set; } = "";

        public override string ToString()
        {
            return japanese;
        }
    }

    public class MiniImage
    {
        [JsonProperty("default")]
        public string default_language { get; set; }
    }

    public class LargeImage
    {
        [JsonProperty("default")]
        public string default_language { get; set; }

        public string japanese { get; set; }
    }

    public class IngameImage
    {
        [JsonProperty("default")]
        public string default_language { get; set; }
    }

    public class Reference
    {
        public int card_id { get; set; }
        public string ref_type { get; set; }
        public int count { get; set; }
    }

    public class SetInfo
    {
        public int set_id { get; set; }
        public int pack_item_def { get; set; }
        public Name name { get; set; }
    }

    public class CardData
    {
        public int card_id { get; set; }
        public int base_card_id { get; set; }
        public string card_type { get; set; }
        public CardName card_name { get; set; }
        public CardText card_text { get; set; }
        public MiniImage mini_image { get; set; }
        public LargeImage large_image { get; set; }
        public IngameImage ingame_image { get; set; }
        public string illustrator { get; set; }
        public string rarity { get; set; }
        public bool is_blue { get; set; }
        public bool is_black { get; set; }
        public bool is_green { get; set; }
        public bool is_red { get; set; }
        public int item_def { get; set; }
        public int attack { get; set; }
        public int armor { get; set; }
        public int hit_points { get; set; }
        public int mana_cost { get; set; }
        public string sub_type { get; set; } = "";
        public int gold_cost { get; set; } = 0;
        public int charges { get; set; }
        public bool is_crosslane { get; set; }
        public IList<Reference> references { get; set; }

        public string sub_card_name => card_name.english;

        public string notag_card_text
        {
            get
            {
                Regex re2 = new Regex("<.*?>");
                return re2.Replace(card_text.japanese, "");
            }
        }
    }

    public class CardSet
    {
        public int version { get; set; }
        public SetInfo set_info { get; set; }
        public List<CardData> card_list { get; set; }
    }

    public class ApiResponseData
    {
        public CardSet card_set { get; set; }
    }
}

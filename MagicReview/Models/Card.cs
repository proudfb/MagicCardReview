using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class Card
    {
        public string name { get; set; }
        public int cardIndex { get; set; }
        public int conManaCost { get; set; }
        public List<AppEnums.Type> type { get; set; }
        public string subtype { get; set; } //will eventually be an enum
        public List<AppEnums.Color> color { get; set; }
        public List<AppEnums.KeywordAbility> keywordAbility { get; set; }
        public List<AppEnums.KeywordAction> keywordAction { get; set; }
        public List<AppEnums.AbilityWord> abilityWord { get; set; }
    }
}
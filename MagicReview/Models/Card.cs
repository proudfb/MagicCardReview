using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicReview.Models
{
    public class Card
    {
        [Required]
        public string name { get; set; }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RegularExpression(@"[a-zA-z][a-zA-z][a-zA-z]\d\d\d")]
        public string ID { get; set; }

        [Required]
        public int conManaCost { get; set; }

        //Alright, this is very complex, so let me explain it:
        [RegularExpression(
            //This part checks for generic mana costs
            //This means either "0" without anything following it, or zero to three "x"s, then an optional digit (1 through 9), then any number of digits.
            //It will match "xx1" or "15", but not "09" or "a"
            @"0|(x{0,3}([1-9]\d*)?" + 

            //This next part checks for hybrid mana costs that start with white mana.
            //This means White/Blue, White/Black, or White Phyrexian.
            //The syntax is: "(w/" plus any one of "u", "b", or "p", plus ")".
            //You can deliniate this substring with a single preceding space.
            //It will match "(w/b)(w/b)" and " (w/u)(w/b)", 
            //but not "w/bw/u" or "(w/b) (w/b)".
            @"(\s?(\(w\/[ubp]\))*)?" +
            
            //This part checks for generic/white hybrid mana costs.
            //This means the single string "(2/w)".
            //You can deliniate this substring with a single preceding space.
            //It will match "(2/w)" or " (2/w)(2/w)(2/w)", but not "(2/w) (2/w)".
            @"(\s?(\(2\/w\))*)?" +
            
            //This last part simply checks for an optional space, then any number of "w"s.
            @"\s?w*" +

            //Repeat this process for the other colors (and the colorless symbol).
            @"(\s?(\(u\/[brp]\))*)?(\s?(\(2\/u\))*)?\s?u*" +
            @"(\s?(\(b\/[rgp]\))*)?(\s?(\(2\/b\))*)?\s?b*" +
            @"(\s?(\(r\/[wgp]\))*)?(\s?(\(2\/r\))*)?\s?r*" +
            @"(\s?(\(g\/[wup]\))*)?(\s?(\(2\/g\))*)?\s?g*" +
            @"\s?c*)")]
        [Required]
        public string manaCost { get; set; }

        //[Required]
        public List<AppEnums.Type> types { get; set; }

        //[Required]
        public List<AppEnums.Color> colors { get; set; }

        public List<AppEnums.KeywordAbility> keywordAbilities { get; set; }

        public List<AppEnums.KeywordAction> keywordActions { get; set; }

        public List<AppEnums.AbilityWord> abilityWords { get; set; }

        public string rulesText { get; set; }

        public string flavorText { get; set; }

        public virtual ICollection<Review> reviews { get; set; }
    }
}
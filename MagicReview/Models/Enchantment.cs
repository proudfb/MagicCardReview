using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MagicReview.Models
{
    public class Enchantment : Card
    {
        [Required]
        public int cardID { get; set; }

        [Required]
        public bool isLegendary { get; set; }

        public List<AppEnums.EnchantmentType> enchantTypes { get; set; }
    }
}
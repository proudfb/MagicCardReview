using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicReview.Models
{
    public class Enchantment : Card
    {
        
        public bool isLegendary { get; set; }

        public List<AppEnums.EnchantmentType> enchantTypes { get; set; }

        public Enchantment()
        {

        }
    }
}
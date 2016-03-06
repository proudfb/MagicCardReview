using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MagicReview.Models
{
    public class Creature : Card
    {
        [Required]
        public int cardID { get; set; }

        [Required]
        public List<AppEnums.CreatureType> creatureTypes { get; set; }

        [Required]
        public bool isLegendary { get; set; }

        [Required]
        public bool isArtifact { get; set; }

        [Required]
        public bool isEnchantment { get; set; }

        [Required]
        public int power { get; set; }

        [Required]
        public int toughness { get; set; }
    }
}
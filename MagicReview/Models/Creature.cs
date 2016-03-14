using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicReview.Models
{
    public class Creature : Card
    {
        public List<AppEnums.CreatureType> creatureTypes { get; set; }

        
        public bool isLegendary { get; set; }

        
        public bool isArtifact { get; set; }

        
        public bool isEnchantment { get; set; }

        
        public int power { get; set; }

        
        public int toughness { get; set; }

        public Creature()
        {

        }

    }
}
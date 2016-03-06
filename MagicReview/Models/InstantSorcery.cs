using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class InstantSorcery : Card
    {
        [Required]
        public int cardID { get; set; }

        [Required]
        public bool isInstant { get; set; }

        public List<AppEnums.SpellType> spellTypes { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class Land : Card
    {
        [Required]
        public int cardID { get; set; }

        [Required]
        public bool isLegendary { get; set; }

        [Required]
        public bool isBasic { get; set; }

        public List<AppEnums.LandType> landTypes { get; set; }
    }
}
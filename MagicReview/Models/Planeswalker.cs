using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class Planeswalker : Card
    {
        [Required]
        public int cardID { get; set; }

        [Required]
        public AppEnums.PlaneswalkerType planeswalkerType { get; set; }

        [Required]
        public int loyaltyCounters { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace MagicReview.Models
{
    public class Planeswalker : Card
    {
        
        public AppEnums.PlaneswalkerType planeswalkerType { get; set; }

        
        public int loyaltyCounters { get; set; }

        public Planeswalker()
        {

        }
    }
}
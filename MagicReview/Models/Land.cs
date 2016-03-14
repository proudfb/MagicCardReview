using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicReview.Models
{
    public class Land : Card
    {
        
        public bool isLegendary { get; set; }

        
        public bool isBasic { get; set; }

        public List<AppEnums.LandType> landTypes { get; set; }

        public Land()
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class Creature : Card
    {
        public int power { get; set; }
        public int toughness { get; set; }
    }
}
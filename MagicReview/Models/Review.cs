using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class Review
    {
        public int cardIndex { get; set; }
        public int reviewIndex { get; set; }
        public string username { get; set; }
        public string reviewText { get; set; }
    }
}
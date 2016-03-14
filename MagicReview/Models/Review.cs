using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicReview.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [RegularExpression(@"[a-zA-z][a-zA-z][a-zA-z]\d\d\d")]
        public string cardID { get; set; }
        public int userID { get; set; }

        public string reviewText { get; set; }

        public Review()
        {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MagicReview.Models
{
    public class Review
    {
        public int cardID { get; set; }
        public int reviewIndex { get; set; }
        public string username { get; set; }
        public string reviewText { get; set; }
    }
}
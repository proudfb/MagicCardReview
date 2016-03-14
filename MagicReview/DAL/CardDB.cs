using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class CardDB : DbContext
    {
        public CardDB()
            : base("CardDB")
        {

        }

        public DbSet<Review> reviews { get; set; }
        public DbSet<Card> cards { get; set; }
        public DbSet<User> users { get; set; }
    }
}
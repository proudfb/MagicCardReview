using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagicReview.DAL
{
    public class CardDB : DbContext
    {
        public CardDB()
            : base("CardDB")
        {

        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicReview.Models
{
    public class InstantSorcery : Card
    {
        
        public bool isInstant { get; set; }

        public List<AppEnums.SpellType> spellTypes { get; set; }

        public InstantSorcery()
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MagicReview.Models
{
    public class Artifact : Card
    {
        [Required]
        public int cardID { get; set; }

        [Required]
        public bool isLegendary { get; set; }

        [Required]
        public List<AppEnums.ArtifactType> artifactTypes { get; set; }
    }
}
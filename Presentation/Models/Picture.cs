using IdentityReview.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IdentityReview.Presentation.Models {
    public class Picture : IDbEntity, IActivatable {
        public int Id { get; set; }

        public bool Active { get; set; } = true;

        [InverseProperty("Pictures")]
        public ApplicationUser Owner { get; set; }

        [Url]
        public string Url { get; set; }
    }
}
using IdentityReview.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdentityReview.Presentation.Models {
    public class Post : IDbEntity, IActivatable{

        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public ApplicationUser Owner { get; set; }
        public IList<Category> Categories { get; set; }
        public Location Locale { get; set; }
        [Url]
        public Picture Picture { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
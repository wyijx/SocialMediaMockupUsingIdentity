using IdentityReview.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityReview.Presentation.Models {
    public class Category : IDbEntity, IActivatable {
        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public string Name { get; set; }
        public IList<Post> Posts { get; set; }
    }
}
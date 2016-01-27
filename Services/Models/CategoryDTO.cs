using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityReview.Services.Models {
    public class CategoryDTO {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<PostDTO> Posts { get; set; }
    }
}
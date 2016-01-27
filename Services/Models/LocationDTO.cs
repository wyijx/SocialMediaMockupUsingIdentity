using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityReview.Services.Models {
    public class LocationDTO {
        public int Id { get; set; }
        public IList<PostDTO> Posts { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
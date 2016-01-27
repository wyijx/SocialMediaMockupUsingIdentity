using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityReview.Services.Models {
    public class PictureDTO {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Url { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityReview.Services.Models {
    public class PostDTO {
        //public int Id { get; set; }
        public ApplicationUserDTO Owner { get; set; }
        //only retrieve category name
        public IList<string> Categories { get; set; }
        //convert Location object to a string
        public string Locale { get; set; }
        public string Picture { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
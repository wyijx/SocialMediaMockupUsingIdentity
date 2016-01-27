using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityReview.Services.Models {
    public class ApplicationUserDTO {
        public string ProfilePictureUrl { get; internal set; }
        public string UserName { get; set; }
    }
}
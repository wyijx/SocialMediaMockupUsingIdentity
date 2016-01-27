using IdentityReview.Domain;
using IdentityReview.Presentation.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentityReview.Infrastructure {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();
        }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Location> Locations { get; set; }
        public IDbSet<Picture> Pictures { get; set; }
        public IDbSet<Post> Posts { get; set; }
    }
}
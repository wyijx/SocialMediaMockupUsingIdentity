using IdentityReview.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentityReview.Infrastructure {
    public class UserRepository {

        private ApplicationDbContext _db;

        public UserRepository(DbContext db) {
            _db = (ApplicationDbContext)db;
        }

        public IQueryable<ApplicationUser> GetFollowings(string userName) {
            
            return  from u in _db.Users
                             from following in u.Following
                             where u.UserName == userName
                             select following;
        }

        public bool UserExistsCheck(string userName) {
            return _db.Users.Any(u => u.UserName == userName);
        }
    }
}
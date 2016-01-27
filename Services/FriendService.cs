using IdentityReview.Infrastructure;
using IdentityReview.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityReview.Services {
    public class FriendService {

        private UserRepository _userRepo;

        public FriendService(UserRepository userRepo) {
            _userRepo = userRepo;
        }

        public IList<ApplicationUserDTO> GetFriendsList(string currentUser) {
            var friends = _userRepo.GetFollowings(currentUser);

            return (from f in friends
                    select new ApplicationUserDTO() {
                        UserName = f.UserName,
                        ProfilePictureUrl = f.ProfilePicture.Url
                    }).ToList();
        }
    }
}
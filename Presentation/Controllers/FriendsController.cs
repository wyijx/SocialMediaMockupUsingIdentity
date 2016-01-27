using IdentityReview.Services;
using IdentityReview.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IdentityReview.Presentation.Controllers
{
    public class FriendsController : ApiController
    {
        private FriendService _friendService;

        public FriendsController(FriendService friendService) {
            _friendService = friendService;
        }
        [Authorize]
        public IList<ApplicationUserDTO> Get() {
            return _friendService.GetFriendsList(User.Identity.Name);
        }
    }
}

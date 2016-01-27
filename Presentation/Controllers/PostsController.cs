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
    public class PostsController : ApiController
    {
        private PostService _postService;

        public PostsController(PostService postService) {
            _postService = postService;
        }
        [Authorize]
        // Return a list of news feed posts
        public IList<PostDTO> Get() {
            // argumetn for later User.Identity.Name
            return _postService.GetNewsFeed(User.Identity.Name);
        }

        [HttpGet]
        [Route("api/posts/{username}")]
        public IHttpActionResult GetProfile(string username) {

            var posts = _postService.GetNewsFeed(username);

            if(posts != null) {
                return Ok(posts);
            }

            return BadRequest();
        }
    }
}

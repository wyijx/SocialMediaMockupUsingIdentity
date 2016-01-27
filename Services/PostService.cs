using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityReview.Services.Models;
using IdentityReview.Infrastructure;
using Microsoft.AspNet.Identity;

namespace IdentityReview.Services {
    public class PostService {

        private PostRepository _postRepo;
        private UserRepository _userRepo;

        public PostService(PostRepository postRepo, UserRepository userRepo) {
            _postRepo = postRepo;
            _userRepo = userRepo;
        }

        /// <summary>
        ///  News Feed Contains all user's posts as well as all
        ///  the user's friends posts.
        /// </summary>
        /// <returns></returns>
        public IList<PostDTO> GetNewsFeed(string currentUser) {

            var followings = (from u in _userRepo.GetFollowings(currentUser)
                              select u.UserName).ToList();

            followings.Add(currentUser);
            
            return (from p in _postRepo.GetPostsForUsers(followings.ToArray())
                    select new PostDTO() {
                        Locale = p.Locale.City + ", " + p.Locale.State,
                        Message = p.Message,
                        CreatedDate = p.CreatedDate,
                        Picture = p.Picture.Url,
                        Categories = (from c in p.Categories
                                      select c.Name).ToList(),
                        Owner = new ApplicationUserDTO() {
                            UserName = p.Owner.UserName
                        }
                    }).ToList();
        }

        public IList<PostDTO> GetPostsForUser(string userName) {

            if(_userRepo.UserExistsCheck(userName)) {
                return (from p in _postRepo.GetPostsForUsers(userName)
                        select new PostDTO() {
                            Locale = p.Locale.City + ", " + p.Locale.State,
                            Message = p.Message,
                            CreatedDate = p.CreatedDate,
                            Picture = p.Picture.Url,
                            Categories = (from c in p.Categories
                                          select c.Name).ToList(),
                            Owner = new ApplicationUserDTO() {
                                UserName = p.Owner.UserName
                            }
                        }).ToList();
            }

            return null;
        }
    }
}
namespace IdentityReview.Controllers {

    export class ProfileFeedController {

        public posts: any;

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get(`/api/posts/${$routeParams.userName}`)
                .then((response) => {
                    this.posts = response.data;
                });
        }
    }
}
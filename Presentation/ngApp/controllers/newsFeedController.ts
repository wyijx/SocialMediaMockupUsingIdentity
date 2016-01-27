namespace IdentityReview.Controllers {
    export class NewsFeedController {
        public posts: any;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/posts')
                .then((response) => {
                    this.posts = response.data;
                });
        }
    }
}
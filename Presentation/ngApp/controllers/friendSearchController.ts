namespace IdentityReview.Controllers {

    export class FriendSearchController {

        public friends: any;

        public constructor(private $http: ng.IHttpService) {

            this.$http.get('/api/friends')
                .then((response) => {
                    this.friends = response.data;
                });
        }
    }
}
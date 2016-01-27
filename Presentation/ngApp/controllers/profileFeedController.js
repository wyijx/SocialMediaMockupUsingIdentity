var IdentityReview;
(function (IdentityReview) {
    var Controllers;
    (function (Controllers) {
        var ProfileFeedController = (function () {
            function ProfileFeedController($http, $routeParams) {
                var _this = this;
                this.$http = $http;
                this.$routeParams = $routeParams;
                $http.get("/api/posts/" + $routeParams.userName)
                    .then(function (response) {
                    _this.posts = response.data;
                });
            }
            return ProfileFeedController;
        })();
        Controllers.ProfileFeedController = ProfileFeedController;
    })(Controllers = IdentityReview.Controllers || (IdentityReview.Controllers = {}));
})(IdentityReview || (IdentityReview = {}));

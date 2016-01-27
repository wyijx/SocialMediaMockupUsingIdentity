var IdentityReview;
(function (IdentityReview) {
    var Controllers;
    (function (Controllers) {
        var NewsFeedController = (function () {
            function NewsFeedController($http) {
                var _this = this;
                this.$http = $http;
                $http.get('/api/posts')
                    .then(function (response) {
                    _this.posts = response.data;
                });
            }
            return NewsFeedController;
        })();
        Controllers.NewsFeedController = NewsFeedController;
    })(Controllers = IdentityReview.Controllers || (IdentityReview.Controllers = {}));
})(IdentityReview || (IdentityReview = {}));

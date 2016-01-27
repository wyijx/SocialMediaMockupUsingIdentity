var IdentityReview;
(function (IdentityReview) {
    var Controllers;
    (function (Controllers) {
        var FriendSearchController = (function () {
            function FriendSearchController($http) {
                var _this = this;
                this.$http = $http;
                this.$http.get('/api/friends')
                    .then(function (response) {
                    _this.friends = response.data;
                });
            }
            return FriendSearchController;
        })();
        Controllers.FriendSearchController = FriendSearchController;
    })(Controllers = IdentityReview.Controllers || (IdentityReview.Controllers = {}));
})(IdentityReview || (IdentityReview = {}));

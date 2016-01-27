var IdentityReview;
(function (IdentityReview) {
    var Controllers;
    (function (Controllers) {
        var SearchController = (function () {
            function SearchController($http) {
                this.$http = $http;
            }
            return SearchController;
        })();
        Controllers.SearchController = SearchController;
    })(Controllers = IdentityReview.Controllers || (IdentityReview.Controllers = {}));
})(IdentityReview || (IdentityReview = {}));

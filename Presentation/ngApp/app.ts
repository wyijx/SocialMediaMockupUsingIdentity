namespace IdentityReview {
    angular.module('IdentityReview', ['ngRoute', 'ui.bootstrap'])

    angular.module('IdentityReview').factory('authInterceptor',
        ($q: ng.IQService, $window: ng.IWindowService, $location: ng.ILocationService) => {
            return {
                request: (config) => {
                    config.headers = config.headers || {};
                    let token = $window.localStorage.getItem('token');
                    if (token) {
                        config.headers.Authorization = `Bearer ${token}`;
                    }
                    return config;
                },
                responseError: (response) => {
                    if (response.status === 401) {
                        $location.path('/login');
                    }
                    return response || $q.when(response);
                }
            }
        });

    angular.module('IdentityReview')
        .config(function ($routeProvider: ng.route.IRouteProvider, $httpProvider: ng.IHttpProvider) {
            $routeProvider
                .when('/', {
                    templateUrl: '/Presentation/ngApp/views/newsFeed.html',
                    controller: IdentityReview.Controllers.NewsFeedController,
                    controllerAs: 'controller'
                })
                .when('/profile/:username', {
                    templateUrl: 'Presentation/ngApp/views/newsFeed.html',
                    controller: IdentityReview.Controllers.ProfileFeedController,
                    controllerAs: 'controller'
                })
                .when('/register', {
                    templateUrl: 'Presentation/ngApp/views/register.html',
                    controller: IdentityReview.Controllers.AuthController,
                    controllerAs: 'controller'
                })
                .when('/friends', {
                    templateUrl: 'Presentation/ngApp/views/friendSearch.html',
                    controller: IdentityReview.Controllers.FriendSearchController,
                    controllerAs: 'controller'
                })
                .when('/login', {
                    templateUrl: 'Presentation/ngApp/views/login.html',
                    controller: IdentityReview.Controllers.AuthController,
                    controllerAs: 'controller'
                });

            $httpProvider.interceptors.push('authInterceptor');
        });
}
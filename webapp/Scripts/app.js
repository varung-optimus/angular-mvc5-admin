var app = angular.module('app', ['ngRoute']);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/form', {
            templateUrl: '/form/'
        })
        .otherwise({
            redirectTo: '/home/'
        });
}
configFunction.$inject = ['$routeProvider'];

app.config(configFunction);
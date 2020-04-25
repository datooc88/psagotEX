var app = angular.module("movies", []);
var uri = 'https://localhost:44302/api/';

app.controller('moviesController', function ($scope, $http) {

    $http({
        method: 'GET',
        url: uri + "GetAllMovies"
    }).then(function successCallback(response) {
        $scope.movies = response.data;
    }, function errorCallback(response) {

    });

    $scope.updateOrder = function (item) {
        $scope.selectedOrder = item;
    }
});

app.controller('movieController', function ($scope, $http) {

    $http({
        method: 'GET',
        url: uri + "GetMovie/" + location.pathname.split('/').slice(-1)[0]
    }).then(function successCallback(response) {
        $scope.movie = response.data;
    }, function errorCallback(response) {

    });

});
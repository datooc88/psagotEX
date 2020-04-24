var app = angular.module("movies", []);

app.controller('moviesController', function ($scope, $http) {
    var uri = 'https://localhost:44302/api/';

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
angular.module('phsApp').controller('HomeController', ['$scope', '$http', function ($scope, $http) {

    $scope.Categories = [];

    $http.get(appGlobalSettings.apiBaseUrl + '/category')
    .then(function (data) {
        $scope.Categories = data.data;
    }, function (error) {
    });


}]);
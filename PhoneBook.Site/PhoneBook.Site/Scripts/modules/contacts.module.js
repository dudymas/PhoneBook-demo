angular.module("contacts", ["ngResource"])
    .controller("ContactsCtrl", function ($scope, $http) {
        $scope.handleData = function (data) {
            $scope.contacts = data;
        };
        $http.get('api/Contact').success($scope.handleData);
    });
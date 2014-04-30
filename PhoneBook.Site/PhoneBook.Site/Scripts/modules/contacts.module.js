angular.module('contacts', ['ngResource'])
    .controller('ContactsCtrl', function ($scope, $http) {
        $scope.handleData = function handleData(data) {
            $scope.contacts = data;
        };
        $http.get('api/Contact').success($scope.handleData);
    })
    .controller('ContactCtrl', function ($scope, $http) {
        $scope.save = function save(contact) {
            $scope.progress = true;
            $http.put('api/Contact/' + contact.Id, contact)
                .success(function (resp) {
                    $scope.progress = false;
                });
            $scope.editing = false;
            $scope.creating = false;
        };
        $scope.edit = function edit() {
            $scope.editing = true;
        };
        $scope.create = function create() {
            $scope.creating = true;
        }
    });
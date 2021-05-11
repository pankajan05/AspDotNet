var myApp = angular.module("myApp", [])
    .controller("employeeCtrl", function ($scope, $http) {

        $http({
                method: 'GET',
                url: "/employee/getEmployee"
            })
            .then( function(result) {
                $scope.employees = result.data;
                console.log($scope.employees);
            },function (error) {
                console.log(error);
            });

    });
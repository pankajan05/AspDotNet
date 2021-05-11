var myApp = angular.module("myApp", [])
                    .controller("employeeCtrl",
                        function($scope, $http) {
                            $http.get("https://localhost:44378/employee/getEmployee")
                                .success(function(result) {
                                    $scope.employees = result;
                                    console.log(result);
                                })
                                .error(function(error) {
                                    console.log(error);
                                });

                        });
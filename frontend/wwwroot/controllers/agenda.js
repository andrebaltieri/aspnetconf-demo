(function () {
    'use strict';
    angular.module('app').controller('AgendaCtrl', function($scope, $http){
        $scope.agenda = [];

        $http.get('http://localhost:5001/api/agenda').success(function (data) {
            console.log(data);
        });
    });
})();
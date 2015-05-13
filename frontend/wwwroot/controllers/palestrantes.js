(function () {
    'use strict';
    angular.module('app').controller('PalestrantesCtrl', function($scope, $http){
        $scope.palestrantes = [];

        $http.get('http://localhost:5001/api/casters').success(function (data) {
            console.log(data);
        });
    });
})();
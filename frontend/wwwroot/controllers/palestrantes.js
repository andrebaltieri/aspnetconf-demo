(function () {
    'use strict';
    angular.module('app').controller('PalestrantesCtrl', function($scope, $http){
        $scope.casters = [];

        $http.get('data/casters.json').success(function (data) {
            $scope.casters = angular.fromJson(data);
        });

        $scope.addLike = function (caster) {
            caster.likes++;
        };
    });
})();
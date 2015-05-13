(function () {
    'use strict';
    angular.module('app').controller('MensagensCtrl', function($scope, $http){
        $scope.messages = [];

        var db = new Firebase("https://aspnetconfbr.firebaseio.com/");
        db.child("messages").orderByKey().limitToLast(6).on("child_added", function(snapshot) {
            $scope.messages.push(angular.fromJson(snapshot.val()));
            $scope.$apply();
        });
    });
})();
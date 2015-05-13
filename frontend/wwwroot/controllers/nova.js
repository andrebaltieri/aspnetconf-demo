(function () {
    'use strict';
    angular.module('app').controller('NovaMensagemCtrl', function($scope, $http, $filter){
        $scope.myImage='';
        $scope.myCroppedImage='';
        $scope.message="";
        $scope.twitter="";

        var handleFileSelect=function(evt) {
            var file=evt.currentTarget.files[0];
            var reader = new FileReader();
            reader.onload = function (evt) {
                $scope.$apply(function($scope){
                    $scope.myImage=evt.target.result;
                });
            };
            reader.readAsDataURL(file);
        };

        angular.element(document.querySelector('#fileInput')).on('change',handleFileSelect);

        $scope.send = function () {
            var data = {
                image:$scope.myCroppedImage,
                message:$scope.message,
                date: $filter('date')(new Date(), "yyyy-MM-ddTHH:mm"),
                twitter: $scope.twitter
            };
            $http.post('https://aspnetconfbr.firebaseio.com/messages.json', data).success(function () {
                Materialize.toast('Foto enviada!', 4000);
            });
        }
    });
})();
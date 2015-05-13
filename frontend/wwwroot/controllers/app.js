(function () {
    'use strict';
    angular.module('app', ['ngRoute', 'ngImgCrop']);
    angular.module('app').config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                controller: 'HomeCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/main.html'
            })
            .when('/palestrantes', {
                controller: 'PalestrantesCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/palestrantes.html'
            })
            .when('/agenda', {
                controller: 'AgendaCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/agenda.html'
            })
            .when('/mensagens', {
                controller: 'MensagensCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/mensagens.html'
            })
            .when('/nova', {
                controller: 'NovaMensagemCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/nova.html'
            });
    });
})();
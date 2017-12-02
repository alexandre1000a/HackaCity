angular.module('app').config(function ($routeProvider, $locationProvider) {
    // remove o # da url
    $routeProvider
    // para a rota '/', carregaremos o template home.html e o controller 'HomeCtrl'
    .when('/home', {
        templateUrl: 'app/application/home/home.html',
        controller: 'homeController'
    })
        
   
         

    // caso não seja nenhum desses, redirecione para a rota '/'
    .otherwise({ redirectTo: '/home' });

});

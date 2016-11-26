angular.module("ShopApp", ["ngRoute", "ShopApp.Services", "ShopApp.Controllers"])

.config(["$routeProvider", function ($routeProvider) {
    $routeProvider
        .when("/shops", {
            templateUrl: "AngularUI/Views/shopsView.html",
            controller: "shopsController"
        })
        .when("/shop/:id/products", {
            templateUrl: "AngularUI/Views/productsView.html",
            controller: "productsController"
        })
        .otherwise({
            redirectTo: "/shops"
        });
}]);
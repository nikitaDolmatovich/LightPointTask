angular.module("ShopApp.Controllers", ["ShopApp.Services"])

    .controller("shopsController", ["shopFactory", "$scope", function (shopFactory, $scope) {
        $scope.shops = shopFactory.all();
    }])

    .controller("productsController", ["productFactory", "$scope", "$routeParams", function (productFactory, $scope, $routeParams) {
        $scope.products = productFactory.get({ id: $routeParams.id });
    }]);
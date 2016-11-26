angular.module("ShopApp.Services", ["ngResource"])

.factory("shopFactory", ["$resource", function ($resource) {
    return $resource("shop", {}, {
        all: { method: "GET", isArray: true }
    });
}])

.factory("productFactory", ["$resource", function ($resource) {
    return $resource("shop/:id/products", { id: "@id" }, {
        get: { method: "GET", isArray: true }
    });
}]);
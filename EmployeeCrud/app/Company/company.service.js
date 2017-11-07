(function () {
    'use strict';

    angular.module('app.core')
        .factory('CompanyService', CompanyService);

    CompanyService.$inject = ['$resource', 'wabase'];

    function CompanyService($resource, wabase) {

        var serviceBase = wabase + 'api/Company/:id';
        return $resource(serviceBase);

    };

})();
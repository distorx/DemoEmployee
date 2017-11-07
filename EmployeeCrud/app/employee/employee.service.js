(function () {
    'use strict';

    angular.module('app.core')
        .factory('EmployeeService', EmployeeService);

    EmployeeService.$inject = ['$resource', 'wabase'];

    function EmployeeService($resource, wabase) {
        var serviceBase = wabase + 'api/Employees/:id';
        return $resource(serviceBase);
    };

})();
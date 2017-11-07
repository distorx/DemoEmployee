(function () {
    'use strict';

    angular.module('app.core')
        .factory('JobPositionService', JobPositionService);

    JobPositionService.$inject = ['$resource', 'wabase'];

    function JobPositionService($resource, wabase) {

        var serviceBase = wabase + 'api/JobPosition/:id';
        return $resource(serviceBase);

    };

})();
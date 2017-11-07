(function () {
    'use strict';

    angular
        .module('app.employee')
        .controller('EmployeeNewEditController', EmployeeNewEditController);

    EmployeeNewEditController.$inject = ['EmployeeService','JobPositionService','CompanyService'];

    function EmployeeNewEditController(EmployeeService, JobPositionService, CompanyService) {

        var vm = this;
        vm.title = 'New Employee Initiation';

        vm.employee = new EmployeeService();

        //vm.employee.CreatedDate = new Date();

        vm.jobPositions = JobPositionService.query(function () {
            console.log(vm.jobPositions);
        });

        vm.companies = CompanyService.query(function (result) {
            console.log(vm.companies);
        })

    };

})();
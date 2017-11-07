(function () {
    'use strict';

    angular
        .module('app.employee')
        .controller('EmployeeNewEditController', EmployeeNewEditController);

    EmployeeNewEditController.$inject = ['EmployeeService','JobPositionService','CompanyService','ServiceEquipmentService'];

    function EmployeeNewEditController(EmployeeService, JobPositionService, CompanyService,ServiceEquipmentService) {

        var vm = this;
        vm.title = 'New Employee Initiation';

        vm.employee = new EmployeeService();

        vm.finishedWizard = function () {
            console.log('finished wizard');
        };

        vm.cancelledWizard = function () {
            console.log('cancelled wizard');
        };

        vm.jobPositions = JobPositionService.query(function () {
            //console.log(vm.jobPositions);
        });

        vm.companies = CompanyService.query(function () {
            //console.log(vm.companies);
        })

        vm.serviceEquipments = ServiceEquipmentService.query();

    };

})();
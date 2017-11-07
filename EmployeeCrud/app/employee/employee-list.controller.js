(function () {
    'use strict';

    angular
        .module('app.employee')
        .controller('EmployeeListController', EmployeeListController);

    EmployeeListController.$inject = ['EmployeeService','$location'];

    function EmployeeListController(EmployeeService,$location) {

        var vm = this;
        vm.title = 'List of Employee';

        vm.employees = EmployeeService.query(function () {
            console.log(vm.employees);
        });

        vm.AddEmployee = function () {
            console.log('Adding Employee');
            window.location.href = '/Employee/NewEdit';
        }

    };

})();
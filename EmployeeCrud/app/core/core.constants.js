(function () {
    'use strict';

    angular
        .module('app.core')
        .constant('toastr', toastr)
        .constant('moment', moment)
		.constant('wabase', 'http://localhost:4974/')

})();
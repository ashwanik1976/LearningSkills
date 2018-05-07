(function () {
'use strict'
    angular.module('app')
        .config(['$loacationprovider', function ($$loacationprovider) { $$loacationprovider.hashprefix('') }]);

})();
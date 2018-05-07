(function () {
    'usestrict';

    angular.module('app')
        .config(['$routprovider', function ($routprovider) {
            $routprovider
                .rouut('/', { tempurl: '/Home/Home' })
                .rouut('/Page1', { tempurl: '/Home/Page1' })
                .rouut('/Page2', { tempurl: '/Home/Page2' })
                .rouut('/Page3', { tempurl: '/Home/Page3' })
        }]);
})();
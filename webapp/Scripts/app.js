"use strict";


angular.module('app', [
    'ui.router'
])


angular.module('app').config(function ($stateProvider) {

    $stateProvider
        .state('app.form', {
            data: {
                title: 'Forms'
            }
        });

 

});
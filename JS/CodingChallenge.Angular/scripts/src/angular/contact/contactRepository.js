'use strict';

//this is just a mock data.
angular.module('app.contact')
    .value('contactRepository', {
        contacts: [{ id: 1, name: 'Contact1', mobile: '12345678', email: 'contact1.email.com' },
         { id: 2, name: 'Contact2', mobile: '23456788', email: 'contact2.email.com' },
         { id: 3, name: 'Contact3', mobile: '23424788', email: 'contact3.email.com' }
        ]
    });
'use strict'

describe('contactController test', function () {

    var $scope, contactController, $controller, contactService, $filter;
    var contacts = [
        { id: 1, name: 'Contact1', mobile: '12345678', email: 'contact1.email.com' },
        { id: 2, name: 'Contact2', mobile: '23456788', email: 'contact2.email.com' },
        { id: 3, name: 'Contact3', mobile: '23424788', email: 'contact3.email.com' }
    ];

    var newContact = { id: 3, name: 'Contact3', mobile: '23424788', email: 'contact3.email.com' };
    var initController = function () {
        contactController = $controller('contactController',
        {
            $scope: $scope,
            contactService: contactService
            //$filter: $filter
        });
    };

    beforeEach(function () {
        contactService = {
            saveContact: jasmine.createSpy('saveContact').andReturn(contacts),
            deleteContact: jasmine.createSpy('deleteContact').andReturn(contacts),
            getContacts: jasmine.createSpy('getContacts').andReturn(contacts)
        }
    });

    beforeEach(module('app','app.contact'));

    beforeEach(inject(function ($injector) {
        $controller = $injector.get('$controller');
        $scope = $injector.get('$rootScope').$new();
    }));

    it('init controller', function () {
        initController();
        expect($scope.contacts.length).toBe(3);
        expect($scope.newcontact.mobile).toBeNull();
        expect($scope.newcontact.email).toBeNull();
        expect($scope.newcontact.name).toBeNull();
    });

    it('edit contact', function () {
        initController();
        $scope.edit(1);
        expect($scope.newcontact.name).toBe('Contact1');
        expect($scope.newcontact.id).toBe(1);
    });

    it('delete contact', function () {
        initController();
        $scope.delete(1);
        expect($scope.contacts.length).toBe(3);
    });


    it('save contact', function () {
        initController();
        var newContact = { id: 3, name: 'Contact3', mobile: '23424788', email: 'contact3.email.com' };
        $scope.newcontact = newContact;
        $scope.saveContact();
        expect($scope.newcontact.mobile).toBeNull();
        expect($scope.newcontact.email).toBeNull();
        expect($scope.newcontact.name).toBeNull();
    });

    it('save contact when name is empty', function () {
        initController();
        $scope.newcontact.mobile = "2444";
        $scope.saveContact();
        expect($scope.newcontact.mobile).toBe("2444");
    });
});
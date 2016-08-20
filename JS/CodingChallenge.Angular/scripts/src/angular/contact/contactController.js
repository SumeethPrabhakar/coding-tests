'use strict';
angular.module('app.contact')
    .controller('contactController', ['$scope', '$filter', 'contactService', function ($scope, $filter, contactService) {
        $scope.newcontact = null;
        $scope.saveContact = saveContact;
        $scope.edit = editContact;
        $scope.delete = deleteContact;
        init();

        function init() {
            reset();
            $scope.contacts = contactService.getContacts();
        }

        function saveContact() {
            //ideally this would be promise -for now Im just mocking
            /*contactService.saveContact($scope.newcontact)
                    .then(function (data) {
                        reset();
                        $scope.contacts = data;
                    });*/
            if (!$scope.newcontact.name) //assuming name is mandatory any  validation to done using directive and check the form pristine
                return;
            $scope.contacts = contactService.saveContact($scope.newcontact);
            reset();
        };

        function deleteContact(id) {
            $scope.contacts = contactService.deleteContact(id);
        };

        function editContact(id) {
            var contact = $filter('filter')($scope.contacts, { id: id })[0];
            $scope.newcontact = contact;
        };

        function reset() {
            $scope.newcontact =
                {
                    id: null,
                    name: null,
                    mobile: null,
                    email: null
                }
        };
    }]);
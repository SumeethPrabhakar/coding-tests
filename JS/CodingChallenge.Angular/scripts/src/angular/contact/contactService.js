'use strict';

angular.module('app.contact')
    .factory('contactService', ['contactRepository', function (contactRepository) {
        var service = {
            getContacts: getContacts,
            saveContact: saveContact,
            deleteContact: deleteContact
        };
        return service;

        function getContacts() {
            //this should come from API , now mocking
            // return $http.get('/some-url/contacts');
            return contactRepository.contacts;

        }

        function saveContact(contactData) {
            //return $http.post('/some-url/contact', contactData);
            if (contactData) {
                contactData.id = contactRepository.contacts.count++;
                contactRepository.contacts.push(contactData);
            }
            return contactRepository.contacts;
        }

        function deleteContact(contactData) {
            var index = contactRepository.contacts.indexOf(contactData);
            contactRepository.contacts.splice(index, 1);
            return contactRepository.contacts;
        }
    }]);
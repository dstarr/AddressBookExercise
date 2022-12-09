using AddressBook.Repositories;
using Contacts.Data.Repositories;
using Contacts.Services.Entities;

namespace Contacts.Services
{
    public class ContactsService : IContactsService
    {
        private IContactsRepository _contactsRepository;

        public ContactsService()
        {
            _contactsRepository = new ContactsRepository();
        }

        public ContactsService(IContactsRepository contactsRepository)
        {
            this._contactsRepository = contactsRepository;
        }

        public Contact FindContact(int id)
        {
            return new Contact();
        }

        public Contact FindContact(string searchTerm)
        {
            return new Contact();
        }

        public void UpdateContact(Contact contact)
        {

        }

        public void DeleteContact(Contact contact)
        {

        }
    }
}

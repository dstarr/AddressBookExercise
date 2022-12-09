using AddressBook.Entities;

namespace Contacts.Data.Repositories;

public class ContactsRepository : IContactsRepository
{
    public Contact GetContactById(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteContactById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateContact(Contact contact)
    {
        throw new NotImplementedException();
    }

    public List<Contact> FindContacts(string criteria)
    {
        throw new NotImplementedException();
    }


    public List<Contact> GetAll()
    {
        throw new NotImplementedException();
    }
}
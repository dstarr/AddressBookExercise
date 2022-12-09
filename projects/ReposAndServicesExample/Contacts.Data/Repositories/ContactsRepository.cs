using Contacts.Data.Repositories.DTOs;

namespace Contacts.Data.Repositories;

public class ContactsRepository : IContactsRepository
{
    public ContactDTO GetContactById(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteContactById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateContact(ContactDTO contact)
    {
        throw new NotImplementedException();
    }

    public List<ContactDTO> FindContacts(string criteria)
    {
        throw new NotImplementedException();
    }


    public List<ContactDTO> GetAll()
    {
        throw new NotImplementedException();
    }
}
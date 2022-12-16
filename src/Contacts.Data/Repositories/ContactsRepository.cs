using Contacts.Data.DTOs;

namespace Contacts.Data.Repositories;

public class ContactsRepository : IContactsRepository
{
    private readonly DbConfiguration _dbConfiguration;

    public ContactsRepository(DbConfiguration dbConfiguration)
    {
        _dbConfiguration = dbConfiguration;
    }

    public ContactDto GetContactById(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteContactById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateExistingContact(ContactDto contact)
    {
        throw new NotImplementedException();
    }

    public void AddNewContact(ContactDto contact)
    {
        throw new NotImplementedException();
    }

    public List<ContactDto> FindContacts(string criteria)
    {
        throw new NotImplementedException();
    }

    public List<ContactDto> GetAllContacts()
    {
        throw new NotImplementedException();
    }
}
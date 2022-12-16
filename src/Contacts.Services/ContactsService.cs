using Contacts.Data;
using Contacts.Data.Repositories;
using Contacts.Services.Entities;

namespace Contacts.Services;

public class ContactsService : IContactsService
{
    private readonly IContactsRepository _repository;

    public ContactsService()
    {
        DbConfiguration dbConfiguration = new DbConfiguration()
        {
            ContainerName = "",
            DatabaseName = "",
            EndpointUri = "",
            PrimaryKey = ""
        };

        _repository = new ContactsRepository(dbConfiguration);
    }
    public ContactsService(IContactsRepository repository)
    {
        _repository = repository;
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
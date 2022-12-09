using Contacts.Services.Entities;

namespace Contacts.Services;

public interface IContactsService
{
    Contact FindContact(int id);

    Contact FindContact(string searchTerm);

    void UpdateContact(Contact contact);

    void DeleteContact(Contact contact);
}
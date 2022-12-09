using Contacts.Data.Repositories.DTOs;

namespace Contacts.Data.Repositories;

public interface IContactsRepository
{
    public ContactDTO GetContactById(int id);

    public void DeleteContactById(int id);

    public void UpdateContact(Contact contact);

    public List<Contact> GetAll();
    List<Contact> FindContacts(string criteria);
}
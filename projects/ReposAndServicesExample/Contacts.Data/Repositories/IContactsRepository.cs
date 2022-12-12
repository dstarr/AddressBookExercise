using Contacts.Data.Repositories.DTOs;

namespace Contacts.Data.Repositories;

public interface IContactsRepository
{
    public ContactDTO GetContactById(int id);

    public void DeleteContactById(int id);

    public void UpdateExistingContact(ContactDTO contact);
    
    public void AddNewContact(ContactDTO contact);

    public List<ContactDTO> GetAllContacts();
    
    List<ContactDTO> FindContacts(string criteria);
}
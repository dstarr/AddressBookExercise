using Contacts.Data.DTOs;

namespace Contacts.Data.Repositories;

public interface IContactsRepository
{
    public ContactDto GetContactById(int id);

    public void DeleteContactById(int id);

    public void UpdateExistingContact(ContactDto contact);
    
    public void AddNewContact(ContactDto contact);

    public List<ContactDto> GetAllContacts();
    
    List<ContactDto> FindContacts(string criteria);
}
using Contacts.Data.Repositories.DTOs;

namespace Contacts.Data.Repositories;

public interface IContactsRepository
{
    public ContactDTO GetContactById(int id);

    public void DeleteContactById(int id);

    public void UpdateContact(ContactDTO contact);

    public List<ContactDTO> GetAll();
    
    List<ContactDTO> FindContacts(string criteria);
}
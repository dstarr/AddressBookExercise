using Contacts.Data.Repositories;
using Moq;

namespace Contacts.Services.Test
{
    public class ContactsServiceTest
    {
        private Mock<IContactsRepository> _mockRepo;
        private ContactsService _contactsService;

        public ContactsServiceTest()
        {
            _mockRepo = new Mock<IContactsRepository>();

            _contactsService = new ContactsService(_mockRepo.Object);
            
        }

        [Fact]
        public void SavesAContact()
        {
            
        }
    }
}
using AddressBook.Api.Models;
using Contacts.Services;
using Contacts.Services.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactsController : ControllerBase
{
    private readonly ILogger<ContactsController> _logger;
    private readonly IContactsService _contactsService;

    public ContactsController(ILogger<ContactsController> logger, IContactsService contactsService)
    {
        _logger = logger;
        _contactsService = contactsService;
    }

    [HttpGet(Name = "/contact")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ContactModel GetContact(int id)
    {
        var contact = _contactsService.FindContact(id);

        var contactModel = new ContactModel()
        {
            Id = contact.Id
        };

        return contactModel;
    }
}
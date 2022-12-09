namespace Contacts.Services.Entities;

public class Contact
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }
    
    public string City { get; set; }
    
    public string State { get; set; }
    
    public string ZipCode { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string Email { get; set; }
    
    public string Notes { get; set; }
}
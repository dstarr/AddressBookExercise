namespace Contacts.Data.DTOs;

public record AddressDto
{
    public string? Address1 { get; init; }

    public string? Address2 { get; init; }

    public string? City { get; init; }

    public string? Region { get; init; }

    public string? PostalCode { get; init; }

    public string? Country { get; init; }
}
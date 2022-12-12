namespace Contacts.Data.Repositories.DTOs
{
    public record ContactDTO
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string Email { get; init; }

        public string Phone { get; init; }

        public string PhoneNumber { get; init; }

        public string AddressOne { get; init; }

        public string AddressTwo { get; init; }

        public string City { get; init; }

        public string Region { get; init; }

        public string PostalCode { get; init; }

        public string Country { get; init; }

    }
}

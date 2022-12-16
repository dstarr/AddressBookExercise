using Newtonsoft.Json;

namespace Contacts.Data.DTOs
{
    public record ContactDto
    {
        public ContactDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; init; }

        public string Name { get; init; }

        public string? Email { get; init; }

        public string? Phone { get; init; }

        public string? PhoneNumber { get; init; }

        public AddressDto? Address { get; init; }

        [JsonProperty(PropertyName = "partitionKey")]
        public string? PartitionKey { get; init; }
    }
}

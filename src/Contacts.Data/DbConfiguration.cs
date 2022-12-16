namespace Contacts.Data;

public record DbConfiguration
{
    public string? EndpointUri{ get; init; }
    
    public string? PrimaryKey { get; init;}

    public string? DatabaseName { get; init;}

    public string? ContainerName { get; init; }

}
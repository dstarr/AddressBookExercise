namespace Contacts.Data;

public record TestConfiguration
{
    public TestConfiguration(string endpointUri, string primaryKey, string databaseName, string containerName)
    {
        EndpointUri = endpointUri;
        PrimaryKey = primaryKey;
        DatabaseName = databaseName;
        ContainerName = containerName;
    }


    public string EndpointUri{ get; init; }
    
    public string PrimaryKey { get; init;}

    public string DatabaseName { get; init;}

    public string ContainerName { get; init; }

}
using System.Net;
using Contacts.Data.DTOs;
using Contacts.Data.Test.Integration.FakeData;
using Microsoft.Azure.Cosmos;
using static Microsoft.Azure.Cosmos.Container;

namespace Contacts.Data.Test.Integration.Repositories;

[TestClass]
public class ContactRepositoryTests
{
    private readonly string _applicationName = "ContactRepositoryTest";
    private readonly string _containerId = "test-contacts-container";
    private readonly string _databaseId = "integration-test-db";
    private readonly string _endpointUri = "https://ab-db.documents.azure.com:443/";
    private const string _partitionKeyPath = "/partitionKey"; 
    private readonly string _primaryKey = "";


    private Database _database = null!;
    private Container _container = null!;
    private CosmosClient _cosmosClient = null!;

    [TestInitialize]
    public async Task Initialize()
    {
        _cosmosClient = new CosmosClient(_endpointUri, _primaryKey, new CosmosClientOptions()
        {
            ApplicationName = _applicationName
        });

        _database = await this._cosmosClient.CreateDatabaseIfNotExistsAsync(_databaseId);
        
        _container = await this._database.CreateContainerIfNotExistsAsync(_containerId, _partitionKeyPath);
    }

    [TestCleanup]
    public async Task Cleanup()
    {
        // await this._cosmosClient.GetDatabase(_databaseId).DeleteAsync();
    }

    [TestMethod]
    public async Task CanSaveAndDeleteNewContactAsync()
    {
        var contactDto = ContactFactory.Create();

        var writeResponse = await this._container.CreateItemAsync<ContactDto>(contactDto, new PartitionKey(_partitionKeyPath));
        
        Assert.IsNotNull(writeResponse);
        Assert.IsNotNull(writeResponse.Resource);
        Assert.AreEqual(HttpStatusCode.Created, writeResponse.StatusCode);
        
        var deleteResponse = await this._container.DeleteItemAsync<ContactDto>(writeResponse.Resource.Id.ToString(), new PartitionKey(writeResponse.Resource.PartitionKey));
        Assert.IsNotNull(deleteResponse);
        Assert.AreEqual(HttpStatusCode.NoContent, deleteResponse.StatusCode);
    }

    [TestMethod]
    [Ignore]
    public void CanUpdateExistingContactAsync()
    {
        throw new NotImplementedException();
    }
}
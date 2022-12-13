using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace Contacts.Data.Test
{
    public abstract class BaseTest
    {
        protected BaseTest()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("xunit.runner.json", optional: false);
            
            Configuration = builder.Build();


            Console.Write("databaseId: ");
            Console.WriteLine(this.Configuration["databaseId"]);

            // CosmosClient CosmosClient = new CosmosClient(
            //     this.Configuration[""], 
            //     PrimaryKey, 
            //     new CosmosClientOptions()
            // {
            //     ApplicationName = "CosmosDBDotnetQuickstart"
            // });

        }

        public IConfigurationRoot Configuration{ get; init; }
    }
}
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace Contacts.Data.Test
{
    public abstract class TextFixture : IDisposable
    {
        protected TextFixture()
        {
            Configuration = SetupConfig();
            
        }

        public IConfiguration Configuration{ get; set; }

        public void Dispose()
        {
            
        }

        private IConfiguration SetupConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("xunit.runner.json", optional: false);

            return builder.Build();
        }


    }
}
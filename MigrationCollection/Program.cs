using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;

namespace MigrateCosmosDBContainers
{
    public class Program
    {
        private const string _databaseName = "Your Database";
        private const string _containerName = "Your Container";
        private const string _connectionString = "Your Connection String";
        internal static readonly Container _container;

        static Program()
        {
            CosmosClient _cosmosClient = new CosmosClient(_connectionString);
            _container= _cosmosClient.GetContainer(_databaseName, _containerName);
        }


        static async Task Main(string[] args)
        {
            // Move documents from containers
            await Migrate.Migration();
        }
    }
}



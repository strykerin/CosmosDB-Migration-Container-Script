using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;

namespace MigrateCosmosDBContainers
{
    public class Program
    {
        private const string _databaseName = "Your Database";
        private const string _containerNameFrom = "Your Container From";
        private const string _containerNameTo = "Your Container To";
        private const string _connectionString = "Your Connection String";
        internal static readonly Container _containerFrom;
        internal static readonly Container _containerTo;

        static Program()
        {
            CosmosClient _cosmosClient = new CosmosClient(_connectionString);
            _containerFrom = _cosmosClient.GetContainer(_databaseName, _containerNameFrom);
            _containerTo = _cosmosClient.GetContainer(_databaseName, _containerNameTo);
        }


        static async Task Main(string[] args)
        {
            // Move documents from containers
            await Migrate.Migration();
        }
    }
}



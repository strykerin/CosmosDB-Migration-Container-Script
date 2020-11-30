using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace MigrateCosmosDBContainers
{
    public class Migrate
    {
        public static async Task Migration()
        {
            FeedIterator<Car> feedIteratorAccount = Program._container.GetItemLinqQueryable<Car>(false)
                                                                      .Where(car => car.NumberOfWheels == 4)
                                                                      .ToFeedIterator();

            while (feedIteratorAccount.HasMoreResults)
            {
                foreach (Car car in await feedIteratorAccount.ReadNextAsync())
                {
                    car.UniqueKey = car.Id;
                    await Program._container.CreateItemAsync(car);
                }
            }
        }
    }
}

# CosmosDB-Migration-Container-Script

This is a dotnet core console application created to migrate documents from 2 containers in the same database. 

The documents that respect a certain logic will be migrated to a container that has the Unique Key Policy on the property called `UniqueKey`.

We use the `FeedIterator` class to iterate over the documents.

```
FeedIterator<Car> feedIteratorAccount = Program._containerFrom.GetItemLinqQueryable<Car>(false)
                                                            .Where(car => car.NumberOfWheels == 4)
                                                            .ToFeedIterator();

while (feedIteratorAccount.HasMoreResults)
{
    foreach (Car car in await feedIteratorAccount.ReadNextAsync())
    {
        car.UniqueKey = car.Id;
        await Program._containerTo.CreateItemAsync(car);
    }
}
```
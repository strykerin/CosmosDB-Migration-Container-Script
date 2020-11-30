# CosmosDB-Migration-Container-Script

This is a dotnet core console application created to migrate documents from 2 containers in the same database. 

The documents that respect a certain logic will be migrated to a container that has the Unique Key Policy on the property called `UniqueKey`.
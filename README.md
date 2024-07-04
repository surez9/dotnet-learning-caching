# dotnet-learning-caching

1. Run memcached locally
2. Create a new Console Application .NET Core.
3.  Adding Nuget Package
	1. Firstly, add Microsoft.Extensions.DependencyInjection – For dependency injection

	1. Secondly, EnyimMemcachedCore – Required for using Memcached

	1. Finally, Microsoft.Extensions.Logging – Needed for EnyimMemcachedCore to have a Logger Factory

4. Create IoC Container Configuration: create ContainerConfiguration class for register configuration for the application
1. addd CacheRepository and CacheProvider: These classes will encapsulate the functionality of accessing Cache. This is important if we want to abstract the Cache provider from the rest of the application.
2. update the ContainerConfiguration class to reflect the same.
1. update the Program class to set and get cache.
1. run the application.
using dotnet_learning___Caching.cache;
using dotnet_learning___Caching.config;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace dotnet_learning___Caching
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = ContainerConfig.Configure();
            Console.WriteLine("Set Cache");

            var cacheRepository = provider.GetService<ICacheRepository>();
            cacheRepository.Set("key_1", "123");

            Console.WriteLine("Sleep for 1 minutes");
            Thread.Sleep(1000*60*1);

            var cacheProvider = provider.GetService<ICacheProvider>();
            Console.WriteLine($"Value from cache {cacheProvider.GetCache<string>("key_1")}");
            Console.ReadLine();

        }
    }
}
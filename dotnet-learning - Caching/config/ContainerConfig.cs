using dotnet_learning___Caching.cache;
using Enyim.Caching.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_learning___Caching.config
{
    internal static class ContainerConfig
    {
        public static IServiceProvider Configure() {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddEnyimMemcached(o => o.Servers = new List<Server> { new Server
            {
                Address = "localhost",
                Port = 11211
            } });
            services.AddSingleton<ICacheProvider, CacheProvider>();
            services.AddSingleton<ICacheRepository, CacheRepository>();
            return services.BuildServiceProvider();
        }
    }
}

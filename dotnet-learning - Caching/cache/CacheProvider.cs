using Enyim.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_learning___Caching.cache
{
    internal interface ICacheProvider
    { 
        T GetCache<T>(string key);
    }
    internal class CacheProvider : ICacheProvider
    {
        private readonly IMemcachedClient memcachedClient;

        public CacheProvider(IMemcachedClient memcachedClient) {
            this.memcachedClient = memcachedClient;
        }
        public T GetCache<T>(string key)
        {
            return memcachedClient.Get<T>(key);
        }
    }
}

using Enyim.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_learning___Caching.cache
{
    internal interface ICacheRepository { 
        void Set<T>(String key, T value);
    }
    internal class CacheRepository : ICacheRepository
    {
        private readonly IMemcachedClient _memcachedClient;

        public CacheRepository(IMemcachedClient memcachedClient)
        {
            this._memcachedClient = memcachedClient;
        }
        public void Set<T>(String key, T value)
        {
            _memcachedClient.Set(key, value, 60 * 60);
        }
    }
}

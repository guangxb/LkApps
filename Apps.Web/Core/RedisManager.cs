using ServiceStack.Redis;


namespace Apps.Web.Core
{
    public class RedisManager
    {
        public static PooledRedisClientManager ClientManager { get; private set; }
        static RedisManager()
        {
            RedisClientManagerConfig redisConfig = new RedisClientManagerConfig();
            redisConfig.MaxWritePoolSize = 128;
            redisConfig.MaxReadPoolSize = 128;
            ClientManager = new PooledRedisClientManager(new string[] { "127.0.0.1" },
                new string[] { "127.0.0.1" }, redisConfig);
        }
    }
}

using Tavisca.Common.Plugins.Configuration;
using Tavisca.Common.Plugins.Redis;
using Tavisca.Platform.Common.Logging;
using Tavisca.Platform.Common.Plugins.Json;

namespace Tavisca.Libraries.Logging.Debugging
{
    public class LogWriterFactory : ILogWriterFactory
    {
        public IApplicationLogWriter CreateWriter()
        {
            var configProvider = new ConfigurationProvider("exchange_rates_service");
            var redisLogSettingsProvider = new RedisSettingsProvider(configProvider);
            var redisSink = new RedisSink(redisLogSettingsProvider);

            return new LogWriter(JsonLogFormatter.Instance, redisSink, null, configProvider);
        }
    }
}
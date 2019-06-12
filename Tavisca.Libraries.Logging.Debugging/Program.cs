using System;
using Tavisca.Platform.Common.Logging;

namespace Tavisca.Libraries.Logging.Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var logWriterFactory = new LogWriterFactory();
            Logger.Initialize(logWriterFactory);

            var log = new ApiLog
            {
                ApplicationName = "logging_test_app"
            };

            Logger.WriteLogAsync(log);

            Console.ReadLine();
        }
    }
}

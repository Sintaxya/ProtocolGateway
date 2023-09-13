using Serilog;
using Serilog.Core;
using System;

namespace ProtocolGateway
{
    public class LoggingHandler
    {
        public Logger? ConsoleLogger, FileLogger;
        private int loggerId;
        void SetupConsoleLogger()
        {
            ConsoleLogger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }

        void SetupFileLogger()
        {
            FileLogger = new LoggerConfiguration().WriteTo.File($"gw_{loggerId}").CreateLogger();
        }

        public void LogRemoteConnection()
        {
            FileLogger?.Information("Hi file");
            ConsoleLogger?.Information("Hi console");
        }

        public void LogLocalConnection()
        {

        }

        public void LogDataSent()
        {

        }
        public void LogDataReceived()
        {

        }

        public void LogDisconnect()
        {

        }

        public void LogReconnect()
        {

        }

        public void LogTimeout()
        {

        }

        public void LogHandlerStart()
        {
            FileLogger?.Information($"Handler for Protocol Gateway with ID: {loggerId} --> Started");
            ConsoleLogger?.Information($"Handler for Protocol Gateway with ID: {loggerId} --> Started");
        }

        public LoggingHandler(int id, bool fileLoggingEnabled, bool consoleLoggingEnabled)
        {
            loggerId = id;
            if (fileLoggingEnabled)
            {
                SetupFileLogger();
            }
            if (consoleLoggingEnabled)
            {
                SetupConsoleLogger();
            }
        }
    }
}

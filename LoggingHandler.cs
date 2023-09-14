using Serilog;
using Serilog.Core;
using System;

namespace ProtocolGateway
{
    public class LoggingHandler
    {
        public Logger? ConsoleLogger, FileLogger;
        private int loggerId;
        string _gatewayName;
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
            FileLogger?.Information($"{_gatewayName} Handler started.");
            ConsoleLogger?.Information($"{_gatewayName} Handler started.");
        }

        public LoggingHandler(int id, bool fileLoggingEnabled, bool consoleLoggingEnabled, string name)
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
            if (name != null)
            {
                _gatewayName = $"[ {name} ]";
            }
            else
            {
                _gatewayName = $"[ GW-{loggerId} ]";
            }
        }
    }
}

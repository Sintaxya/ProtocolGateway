using Serilog;
using Serilog.Core;
using System;

namespace ProtocolGateway
{
    class LoggingHandler
    {
        public static Logger? ConsoleLogger, FileLogger;

        //Logger GetLoggerInstance()
        //{
        //    if (gwParam.logging_to_console)
        //    {
        //        ConsoleLogger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        //    }
        //    if (gwParam.logging_to_file)
        //    {
        //        FileLogger = new LoggerConfiguration().WriteTo.File($"gw_{gwId}").CreateLogger();
        //    }
        //}
    }
    }

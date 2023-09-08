using Serilog;
using Serilog.Core;

namespace ProtocolGateway
{
    enum ProtocolTypes
    {
        tcp,
        udp,
        websocket,
        http
    }
    class ProtocolGatewayHandler : IHandler
    {
        Logger ConsoleLogger, FileLogger;
        ProtocolFactory factory = new();
        GatewayParam gwParam;
        readonly int gwId;



        public ProtocolGatewayHandler(GatewayParam gatewayParam, int gatewayId)
        {
            gwParam = gatewayParam;
            gwId = gatewayId;
            SetupLoggers();
            StartServer();
            StartClient();
        }


        void SetupLoggers()
        {
            if (gwParam.logging_to_console)
            {
                ConsoleLogger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            }
            if (gwParam.logging_to_file)
            {
                FileLogger = new LoggerConfiguration().WriteTo.File($"gw_{gwId}").CreateLogger();
            }
        }

        void StartServer()
        {
            if (Enum.IsDefined(typeof(ProtocolTypes), gwParam.source.ToLower()))
            {
                var server = factory.CreateServer(gwParam.source);
                server.ListenFilter = gwParam.listen_address_filter;
                server.Port = gwParam.listen_port;
            }
        }

        void StartClient()
        {
            if (Enum.IsDefined(typeof(ProtocolTypes), gwParam.destination.ToLower()))
            {
                var client = factory.CreateClient(gwParam.destination);
                client.DestinationIp = gwParam.destination_ip;
                client.DestinationPort = gwParam.destination_port;
            }
        }

        public void EndpointDataReceived()
        {
            throw new NotImplementedException();
        }
    }
}

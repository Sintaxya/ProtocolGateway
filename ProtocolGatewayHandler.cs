using ProtocolGateway.Config;

namespace ProtocolGateway
{
    enum ProtocolTypes
    {
        tcp,
        udp,
        websocket,
        http
    }
    public class ProtocolGatewayHandler
    {
        ProtocolFactory factory = new();
        GatewayParam gwParam;
        readonly int gwId;
        LoggingHandler _loggingHandler;
        public ProtocolGatewayHandler(GatewayParam gatewayParam, int gatewayId, LoggingHandler loggingHandler)
        {
            gwParam = gatewayParam;
            gwId = gatewayId;
            _loggingHandler = loggingHandler;
            _loggingHandler.LogHandlerStart();
            StartServer();
            StartClient();
        }

        void StartServer()
        {
            if (Enum.IsDefined(typeof(ProtocolTypes), gwParam.source.ToLower()))
            {
                var server = factory.CreateServer(gwParam.source);
                server.ListenFilter = gwParam.listen_address_filter;
                server.ListenPort = gwParam.listen_port;
                server.LoggingHandler = _loggingHandler;
                server.GatewayHandler = this;
            }
        }

        void StartClient()
        {
            if (Enum.IsDefined(typeof(ProtocolTypes), gwParam.destination.ToLower()))
            {
                var client = factory.CreateClient(gwParam.destination);
                client.DestinationIp = gwParam.destination_ip;
                client.DestinationPort = gwParam.destination_port;
                client.LoggingHandler = _loggingHandler;
                client.GatewayHandler = this;
            }
        }

    }
}

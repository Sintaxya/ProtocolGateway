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
    class ProtocolGatewayHandler : IGatewayHandler
    {
        ProtocolFactory factory = new();
        GatewayParam gwParam;
        readonly int gwId;
        public ProtocolGatewayHandler(GatewayParam gatewayParam, int gatewayId)
        {
            gwParam = gatewayParam;
            gwId = gatewayId;
            StartServer();
            StartClient();
        }

        void StartServer()
        {
            if (Enum.IsDefined(typeof(ProtocolTypes), gwParam.source.ToLower()))
            {
                var server = factory.CreateServer(gwParam.source);
                server.ListenFilter = gwParam.listen_address_filter;
                server.Port = gwParam.listen_port;
                server.RegisterHandler(this);
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
            Console.WriteLine("EndpointDataReceived");
        }

        public void EndpointDataSent()
        {
            throw new NotImplementedException();
        }

        public void EndpointConnection()
        {
            throw new NotImplementedException();
        }

        public void LocalConnection()
        {
            throw new NotImplementedException();
        }

        private void ConnectionLogger()
        {
            throw new NotImplementedException();
        }

        private void TrafficLogger()
        {
            throw new NotImplementedException();
        }
    }
}

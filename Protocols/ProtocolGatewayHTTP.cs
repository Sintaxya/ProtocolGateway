namespace ProtocolGateway.Protocols
{

    class HTTPServer : IProtocolServer
    {
        public string ListenFilter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status => throw new NotImplementedException();
        public LoggingHandler LoggingHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ListenPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ProtocolGatewayHandler GatewayHandler { get => _gatewayHandler; set => _gatewayHandler = value; }

        private ProtocolGatewayHandler _gatewayHandler;
        public void OnClientConnected()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
        public void ServerStart()
        {
            throw new NotImplementedException();
        }
        public void ServerStop()
        {
            throw new NotImplementedException();
        }

        void IProtocolServer.OnClientConnected()
        {
            throw new NotImplementedException();
        }

        void ISharedNetworkComponents.Receive()
        {
            throw new NotImplementedException();
        }

        void ISharedNetworkComponents.Send()
        {
            throw new NotImplementedException();
        }

        void IProtocolServer.ServerStart()
        {
            throw new NotImplementedException();
        }

        void IProtocolServer.ServerStop()
        {
            throw new NotImplementedException();
        }
    }

    class HTTPClient : IProtocolClient
    {
        public string DestinationIp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DestinationPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status => throw new NotImplementedException();
        public LoggingHandler LoggingHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ProtocolGatewayHandler GatewayHandler { get => _gatewayHandler; set => _gatewayHandler = value; }

        private ProtocolGatewayHandler _gatewayHandler;
        public void ClientStart()
        {
            throw new NotImplementedException();
        }

        public void ClientStop()
        {
            throw new NotImplementedException();
        }

        public void OnConnect()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }
        public void Send()
        {
            throw new NotImplementedException();
        }

        void IProtocolClient.ClientStart()
        {
            throw new NotImplementedException();
        }

        void IProtocolClient.ClientStop()
        {
            throw new NotImplementedException();
        }

        void IProtocolClient.OnConnect()
        {
            throw new NotImplementedException();
        }

        void ISharedNetworkComponents.Receive()
        {
            throw new NotImplementedException();
        }

        void ISharedNetworkComponents.Send()
        {
            throw new NotImplementedException();
        }
    }
}

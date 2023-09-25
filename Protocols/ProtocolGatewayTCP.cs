namespace ProtocolGateway.Protocols
{

    class TcpServer : IProtocolServer
    {
        public TcpServer()
        {
            Task.Run(() => ServerStart());
        }
        public string ListenFilter { get => _listenFilter; set => _listenFilter = value; }
        private string _listenFilter;
        public bool Status { get => _status; set => _status = value; }
        private bool _status;
        public LoggingHandler LoggingHandler { get => _loggingHandler; set => _loggingHandler = value; }

        private LoggingHandler _loggingHandler;
        public int ListenPort { get => _listenPort; set => _listenPort = value; }
        public ProtocolGatewayHandler GatewayHandler { get => _gatewayHandler; set => _gatewayHandler = value; }

        private ProtocolGatewayHandler _gatewayHandler;

        private int _listenPort;
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
            _gatewayHandler.DataReceived += OnDataReceived;
            return;
        }

        public void ServerStop()
        {
            _status = false;
        }

        public void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    class TcpClient : IProtocolClient
    {
        public string DestinationIp { get => _destinationIp; set => _destinationIp = value; }

        private string _destinationIp;
        public int DestinationPort { get => _destinationPort; set => _destinationPort = value; }
        private int _destinationPort;
        public bool Status { get => _status; set => _status = value; }
        private bool _status;
        public LoggingHandler LoggingHandler { get => _loggingHandler; set => _loggingHandler = value; }

        private LoggingHandler _loggingHandler;
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

        public void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

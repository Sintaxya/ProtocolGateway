using System.Reflection.Metadata.Ecma335;

namespace ProtocolGateway.Protocols
{

    class TcpServer : IProtocolServer
    {
        public TcpServer()
        {
            Console.WriteLine("Hello !");
            Task.Run(() => ServerStart());
        }
        public string ListenFilter { get; set; }

        public int Port { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }
        public LoggingHandler LoggingHandler { get => _loggingHandler; set => _loggingHandler = value; }

        private LoggingHandler _loggingHandler;
        public int ListenPort { get => _listenPort; set => _listenPort = value; }
        public string _listenFilter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            return;
        }

        public void ServerStop()
        {
            throw new NotImplementedException();
        }

    }

    class TcpClient : IProtocolClient
    {
        public string DestinationIp { get; set; }
        public int DestinationPort { get; set; }
        public string Name => throw new NotImplementedException();
        public bool Status => throw new NotImplementedException();
        public LoggingHandler LoggingHandler { get => _loggingHandler; set => _loggingHandler = value; }

        private LoggingHandler _loggingHandler;

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
    }
}

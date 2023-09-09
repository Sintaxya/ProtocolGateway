namespace ProtocolGateway.Protocols
{

    class TcpServer : IProtocolServer
    {
        private IHandler? _handler;
        public TcpServer()
        {
            Console.WriteLine("Hello !");
            Task.Run(() => ServerStart());
        }
        public string ListenFilter { get; set; }

        public int Port { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

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
        public void RegisterHandler(IHandler handler)
        {
            Console.WriteLine("Registering handler");
            _handler = handler;
        }
        public void UnregisterHandler(IHandler handler)
        {
            _handler = null;
        }
    }

    class TcpClient : IProtocolClient
    {
        public string DestinationIp { get; set; }
        public int DestinationPort { get; set; }

        public string Name => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

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

        public void RegisterHandler(IHandler handler)
        {
            throw new NotImplementedException();
        }

        public void Send()
        {
            throw new NotImplementedException();
        }

        public void UnregisterHandler(IHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}

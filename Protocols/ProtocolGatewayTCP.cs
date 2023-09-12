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
        public IGatewayHandler Handler { get => _handler; set => _handler = value; }

        private IGatewayHandler _handler;
        public void OnClientConnected()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }

        public void RegisterHandler(IGatewayHandler handler)
        {
            _handler = handler;
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

        public void UnregisterHandler(IGatewayHandler handler)
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

        public IGatewayHandler Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void RegisterHandler(IGatewayHandler handler)
        {
            throw new NotImplementedException();
        }

        public void Send()
        {
            throw new NotImplementedException();
        }

        public void UnregisterHandler(IGatewayHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}

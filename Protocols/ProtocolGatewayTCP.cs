﻿namespace ProtocolGateway.Protocols
{

    class TcpServer : IProtocolServer, ISharedNetworkComponens
    {
        public TcpServer()
        {
            Console.WriteLine("Hello !");
        }
        public string ListenFilter { get; set; }

        public int Port { get; set; }

        public string Name => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public void OnClientConnected()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }

        public void RegisterHandler()
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

        public void UnregisterHandler()
        {
            throw new NotImplementedException();
        }
    }

    class TcpClient : IProtocolClient, ISharedNetworkComponens
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

        public void RegisterHandler()
        {
            throw new NotImplementedException();
        }

        public void Send()
        {
            throw new NotImplementedException();
        }

        public void UnregisterHandler()
        {
            throw new NotImplementedException();
        }
    }
}

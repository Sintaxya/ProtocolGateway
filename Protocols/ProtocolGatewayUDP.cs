﻿namespace ProtocolGateway.Protocols
{
    class UdpServer : IProtocolServer
    {
        public string ListenFilter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public IGatewayHandler Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void RegisterHandler(IGatewayHandler handler)
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

        public void UnregisterHandler(IGatewayHandler handler)
        {
            throw new NotImplementedException();
        }
    }

    class UdpClient : IProtocolClient
    {
        public string DestinationIp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DestinationPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void RegisterHandler()
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

        public void UnregisterHandler()
        {
            throw new NotImplementedException();
        }

        public void UnregisterHandler(IGatewayHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}

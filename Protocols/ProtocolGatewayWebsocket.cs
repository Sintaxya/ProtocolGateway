﻿namespace ProtocolGateway.Protocols
{
    class WebsocketServer : IProtocolServer, ISharedNetworkComponens
    {
        public string ListenFilter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public event EventHandler<EventArgs> DataReceived;

        public void OnClientConnected()
        {
            throw new NotImplementedException();
        }

        public void RaiseDataReceivedEvent()
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

    class WebsocketClient : IProtocolClient, ISharedNetworkComponens
    {
        public string DestinationIp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DestinationPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public event EventHandler<EventArgs> DataReceived;

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

        public void RaiseDataReceivedEvent()
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

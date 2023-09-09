namespace ProtocolGateway.Protocols
{
    public interface IProtocolServer: ISharedNetworkComponens
    {
        string ListenFilter { get; set; }
        int Port { get; set; }

        void ServerStart();

        void ServerStop();

        void OnClientConnected();
    }
}

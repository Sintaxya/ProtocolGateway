namespace ProtocolGateway
{
    public interface IProtocolServer
    {
        string ListenFilter { get; set; }
        int Port { get; set; }

        void ServerStart();

        void ServerStop();

        void OnClientConnected();
    }
}

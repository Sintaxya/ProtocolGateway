namespace ProtocolGateway.Protocols
{
    public interface IProtocolServer: ISharedNetworkComponents
    {
        string ListenFilter { get; set; }
        int ListenPort { get ; set; }
        void ServerStart();
        void ServerStop();
        void OnClientConnected();
    }
}

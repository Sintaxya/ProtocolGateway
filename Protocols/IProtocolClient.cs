namespace ProtocolGateway.Protocols
{
    public interface IProtocolClient : ISharedNetworkComponents
    {
        string DestinationIp { get; set; }
        int DestinationPort { get; set; }
        void ClientStart();
        void ClientStop();
        void OnConnect();
    }
}

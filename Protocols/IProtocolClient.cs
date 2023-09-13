namespace ProtocolGateway.Protocols
{
    public interface IProtocolClient : ISharedNetworkComponens
    {
        string DestinationIp { get; set; }
        int DestinationPort { get; set; }
        void ClientStart();
        void ClientStop();
        void OnConnect();
    }
}

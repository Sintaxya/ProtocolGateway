namespace ProtocolGateway
{
    public interface IProtocolClient
    {
        string DestinationIp { get; set; }
        int DestinationPort { get; set; }
        void ClientStart();
        void ClientStop();
        void OnConnect();

    }
}

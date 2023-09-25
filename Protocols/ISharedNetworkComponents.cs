namespace ProtocolGateway.Protocols
{
    public interface ISharedNetworkComponents
    {
        bool Status { get; }
        void Receive();
        void Send();
        LoggingHandler LoggingHandler { get; set; }
        ProtocolGatewayHandler GatewayHandler { get; set; }
        void OnDataReceived(object sender, DataReceivedEventArgs e);

    }
}

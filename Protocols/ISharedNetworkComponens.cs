namespace ProtocolGateway.Protocols
{
    public interface ISharedNetworkComponens
    {
        string Name { get; }
        bool Status { get; }
        void Receive();
        void Send();
        void RegisterHandler(IHandler handler);
        void UnregisterHandler(IHandler handler);
    }
}

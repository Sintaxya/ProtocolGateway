using System.Reflection.Metadata;

namespace ProtocolGateway.Protocols
{
    public interface ISharedNetworkComponens
    {
        string Name { get; }
        bool Status { get; }
        void Receive();
        void Send();
        IGatewayHandler Handler { get; set; }
        public void RegisterHandler(IGatewayHandler handler);
    public void UnregisterHandler(IGatewayHandler handler);
    }
}

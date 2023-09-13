using System.Reflection.Metadata;

namespace ProtocolGateway.Protocols
{
    public interface ISharedNetworkComponens
    {
        string Name { get; }
        bool Status { get; }
        void Receive();
        void Send();
        LoggingHandler LoggingHandler { get; set; }
    }
}

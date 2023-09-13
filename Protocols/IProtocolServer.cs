using Serilog.Core;

namespace ProtocolGateway.Protocols
{
    public interface IProtocolServer: ISharedNetworkComponens
    {
        string ListenFilter { get; set; }
        int ListenPort { get ; set; }
        void ServerStart();
        void ServerStop();
        void OnClientConnected();
    }
}

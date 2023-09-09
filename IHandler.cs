namespace ProtocolGateway
{
    public interface IHandler
    {
        void EndpointDataReceived();

        void EndpointDataSent();
        void EndpointConnection();
        void LocalConnection();
    }
}

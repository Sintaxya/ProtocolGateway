namespace ProtocolGateway
{
    public interface IGatewayHandler
    {
        void EndpointDataReceived();

        void EndpointDataSent();
        void EndpointConnection();
        void LocalConnection();
    }
}

namespace ProtocolGateway
{
    interface ISharedNetworkComponens
    {
        string Name { get; }
        bool Status { get; }
        void Receive();
        void Send();

        void RegisterHandler();
        void UnregisterHandler();
    }
}

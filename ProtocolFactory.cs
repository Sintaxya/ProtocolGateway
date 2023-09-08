using ProtocolGateway.Protocols;

namespace ProtocolGateway
{
    public class ProtocolFactory
    {
        private readonly Dictionary<string, Type> serversEnum = new()
        {
                { "tcp" , typeof(TcpServer)},
                { "udp" , typeof(UdpServer)},
                { "websocket" , typeof(WebsocketServer)},
                { "http" , typeof(HTTPServer)},
            };
        private readonly Dictionary<string, Type> clientsEnum = new()
        {
                { "tcp" , typeof(TcpClient)},
                { "udp" , typeof(UdpClient)},
                { "websocket", typeof(WebsocketClient)},
                { "http" , typeof(HTTPClient)},
            };
        internal IProtocolClient CreateClient(string clientClass)
        {
            if (clientsEnum.TryGetValue(clientClass, out Type? clientType))
            {
                return (IProtocolClient)Activator.CreateInstance(clientType);
            }
            else
            {
                throw new ArgumentException($"Invalid client type: {clientClass}");
            }
        }

        internal IProtocolServer CreateServer(string serverClass)
        {
            if (serversEnum.TryGetValue(serverClass, out Type serverType))
            {
                return (IProtocolServer)Activator.CreateInstance(serverType);
            }
            else
            {
                throw new ArgumentException($"Invalid server type: {serverClass}");
            }
        }


    }
}


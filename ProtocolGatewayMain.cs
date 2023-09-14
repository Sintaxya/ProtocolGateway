using ProtocolGateway.Config;
using Serilog;
using System.Linq.Expressions;

namespace ProtocolGateway
{
    class ProtocolGatewayMain
    {
        private static void Main()
        {
            ProtocolGatewayConfig config = new();
            StartHandlers(config.GetConfigInstance());
        }

        static void StartHandlers(ConfigStructure config)
        {
            int gatewayId = 1;
            foreach (var gateway in config.gateway_params)
            {
                if (gateway != null & Convert.ToBoolean(gateway.enabled))
                {
                    var logger = new LoggingHandler(gatewayId, gateway.logging_to_file, gateway.logging_to_console, gateway.name);
                    var handler = new ProtocolGatewayHandler(gateway, gatewayId, logger);
                }
                gatewayId++;
            }
        }
    }
}

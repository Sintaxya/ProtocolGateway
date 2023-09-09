using Newtonsoft.Json;

namespace ProtocolGateway.Config
{
    class ProtocolGatewayConfig
    {
        private static string ConfigName => "config.json";
        private static string ConfigPath => Path.GetFullPath(ConfigName);

        public ConfigStructure config;
        public ProtocolGatewayConfig()
        {
            GetConfig();
        }
        void GetConfig()
        {
            string json = File.ReadAllText(ConfigPath);

            config = JsonConvert.DeserializeObject<ConfigStructure>(json);

        }
    }
    public class ConfigStructure
    {
        public List<GatewayParam> gateway_params;
    }

    public class GatewayParam
    {
        [JsonProperty("enabled")]
        public int enabled;
        [JsonProperty("name")]
        public string name;
        [JsonProperty("listen_address_filter")]
        public string listen_address_filter;
        [JsonProperty("listen_port")]
        public int listen_port;
        [JsonProperty("source")]
        public string source;
        [JsonProperty("destination")]
        public string destination;
        [JsonProperty("destination_ip")]
        public string destination_ip;
        [JsonProperty("destination_port")]
        public int destination_port;
        [JsonProperty("logging_to_console")]
        public bool logging_to_console;
        [JsonProperty("logging_to_file")]
        public bool logging_to_file;
    }
}

namespace ProtocolGateway
{
    public class DataReceivedEventArgs : EventArgs {

        object Data { get; }
        public DataReceivedEventArgs(object data) {
            Data = data;
        }
    }
}

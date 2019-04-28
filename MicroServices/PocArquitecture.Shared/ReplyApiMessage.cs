using NServiceBus;

namespace PocArquitecture.Shared
{
    public class ReplyApiMessage : IMessage
    {
        public string Guid { get; set; }
    }
}

using NServiceBus;
using NServiceBus.Logging;
using PocArquitecture.Shared;
using System;
using System.Threading.Tasks;

namespace PocArquitecture.RequestHandler
{
    public class MyHandler :
    IHandleMessages<MyMessage>
    {
        static ILog log = LogManager.GetLogger<MyHandler>();

        #region MessageHandler
        public Task Handle(MyMessage message, IMessageHandlerContext context)
        {
            log.Info("Message received at endpoint");

            string requestId = Guid.NewGuid().ToString();
            //ReplyOptions replyOptions = new ReplyOptions();
            //replyOptions.RouteReplyTo("PocArquitecture.WriteApi");

            return context.Reply(new ReplyApiMessage() { Guid = requestId });
        }
        #endregion
    }
}

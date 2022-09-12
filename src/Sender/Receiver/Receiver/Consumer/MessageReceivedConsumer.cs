using MassTransit;
using Receiver.Models;

namespace Receiver.Consumer
{
    public class MessageReceivedConsumer : IConsumer<MQMessageEvent>
    {
        private readonly ILogger<MessageReceivedConsumer> _logger;

        public MessageReceivedConsumer(ILogger<MessageReceivedConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<MQMessageEvent> context)
        {
            Console.WriteLine(".... mesaj alındı.....");
            Console.WriteLine(context.Message.Message);

            _logger.LogInformation(context.Message.Message);

            return Task.CompletedTask;

        }
    }
}

using MassTransit;
using System.Threading.Tasks;

namespace Messages
{
    public abstract class BaseConsumer<T> : IConsumer<T> where T : class
    {
        public Task Consume(ConsumeContext<T> context)
        {
            return ConsumeAsync(context);
        }

        public abstract Task ConsumeAsync(ConsumeContext<T> context);
    }
}
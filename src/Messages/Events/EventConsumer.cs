namespace Mercury.Todo.Messages.Events
{
    public abstract class EventConsumer<T> : BaseConsumer<T> where T : BaseEvent
    {
    }
}
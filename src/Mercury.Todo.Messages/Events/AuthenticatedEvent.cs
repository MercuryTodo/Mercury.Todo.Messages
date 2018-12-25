namespace Mercury.Todo.Messages.Events
{
    public abstract class AuthenticatedEvent : BaseEvent
    {
        public string UserId { get; set; }
    }
}
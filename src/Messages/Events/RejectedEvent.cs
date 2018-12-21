namespace Messages.Events
{
    public abstract class RejectedEvent : AuthenticatedEvent
    {
        public string Reason { get; set; }
        public string Code { get; set; }
    }
}
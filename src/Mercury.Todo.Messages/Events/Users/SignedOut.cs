namespace Mercury.Todo.Messages.Events.Users
{
    public class SignedOut : BaseEvent
    {
        public string UserId { get; }
        public string SessionId { get; }

        protected SignedOut()
        {
        }

        public SignedOut(string requestId, string userId, string sessionId)
        {
            RequestId = requestId;
            UserId = userId;
            SessionId = sessionId;
        }
    }
}
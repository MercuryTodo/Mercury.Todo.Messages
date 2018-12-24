namespace Mercury.Todo.Messages.Events.Users
{
    public class MessageOnFacebookWallPosted : AuthenticatedEvent
    {
        public string Message { get; }

        protected MessageOnFacebookWallPosted()
        {
        }

        public MessageOnFacebookWallPosted(string requestId, string userId, string message)
        {
            RequestId = requestId;
            UserId = userId;
            Message = message;
        }
    }
}
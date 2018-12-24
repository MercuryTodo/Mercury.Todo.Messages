namespace Mercury.Todo.Messages.Events.Users
{
    public class PostOnFacebookWallRejected : RejectedEvent
    {
        public string Message { get; }

        protected PostOnFacebookWallRejected()
        {
        }

        public PostOnFacebookWallRejected(string requestId,
            string userId, string code,
            string reason, string message)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            Message = message;
        }
    }
}
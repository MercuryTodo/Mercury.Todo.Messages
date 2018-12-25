namespace Mercury.Todo.Messages.Events.Users
{
    public class SignUpRejected : RejectedEvent
    {
        public string Provider { get; }

        protected SignUpRejected()
        {
        }

        public SignUpRejected(string requestId,
            string userId, string code,
            string reason, string provider)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            Provider = provider;
        }
    }
}
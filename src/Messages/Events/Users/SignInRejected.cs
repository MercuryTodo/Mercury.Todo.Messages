namespace Messages.Events.Users
{
    public class SignInRejected : RejectedEvent
    {
        public string Provider { get; }

        protected SignInRejected()
        {
        }

        public SignInRejected(string requestId,
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
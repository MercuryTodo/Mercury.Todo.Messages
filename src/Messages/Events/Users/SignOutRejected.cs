namespace Messages.Events.Users
{
    public class SignOutRejected : RejectedEvent
    {
        protected SignOutRejected()
        {
        }

        public SignOutRejected(string requestId, string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}
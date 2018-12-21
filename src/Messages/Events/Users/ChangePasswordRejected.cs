namespace Messages.Events.Users
{
    public class ChangePasswordRejected : RejectedEvent
    {
        protected ChangePasswordRejected()
        {
        }

        public ChangePasswordRejected(string requestId,
            string userId, string code,
            string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}
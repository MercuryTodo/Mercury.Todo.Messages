namespace Messages.Events.Users
{
    public class ResetPasswordRejected : RejectedEvent
    {
        public string Email { get; }

        protected ResetPasswordRejected()
        {
        }

        public ResetPasswordRejected(string requestId, string reason, string code, string email)
        {
            RequestId = requestId;
            Reason = reason;
            Code = code;
            Email = email;
        }
    }
}
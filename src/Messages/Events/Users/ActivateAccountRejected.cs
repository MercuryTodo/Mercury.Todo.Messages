namespace Messages.Events.Users
{
    public class ActivateAccountRejected : RejectedEvent
    {
        public string Email { get; }

        protected ActivateAccountRejected()
        {
        }

        public ActivateAccountRejected(string requestId,
            string email, string code, string reason, string userId = "")
        {
            RequestId = requestId;
            Email = email;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}
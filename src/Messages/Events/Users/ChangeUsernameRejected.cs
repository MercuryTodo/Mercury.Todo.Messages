namespace Messages.Events.Users
{
    public class ChangeUsernameRejected : RejectedEvent
    {
        public string RejectedUsername { get; }

        protected ChangeUsernameRejected(string rejectedUsername)
        {
            RejectedUsername = rejectedUsername;
        }

        public ChangeUsernameRejected(string requestId,
            string userId, string code,
            string reason, string rejectedUsername)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            RejectedUsername = rejectedUsername;
        }
    }
}
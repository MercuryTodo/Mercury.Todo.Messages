namespace Mercury.Todo.Messages.Events.Users
{
    public class UnlockAccountRejected : RejectedEvent
    {
        public string UnlockUserId { get; }

        protected UnlockAccountRejected()
        {
        }

        public UnlockAccountRejected(string requestId, string userId,
            string reason, string code, string unlockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            Reason = reason;
            Code = code;
            UnlockUserId = unlockUserId;
        }
    }
}
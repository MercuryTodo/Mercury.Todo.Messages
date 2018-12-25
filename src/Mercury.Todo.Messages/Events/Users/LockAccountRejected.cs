namespace Mercury.Todo.Messages.Events.Users
{
    public class LockAccountRejected : RejectedEvent
    {
        public string LockUserId { get; }

        protected LockAccountRejected()
        {
        }

        public LockAccountRejected(string requestId, string userId,
            string reason, string code, string lockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            Reason = reason;
            Code = code;
            LockUserId = lockUserId;
        }
    }
}
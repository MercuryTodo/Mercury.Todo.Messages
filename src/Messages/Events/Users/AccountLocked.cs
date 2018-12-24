namespace Mercury.Todo.Messages.Events.Users
{
    public class AccountLocked : AuthenticatedEvent
    {
        public string LockUserId { get; set; }

        protected AccountLocked()
        {
        }

        public AccountLocked(string requestId, string userId, string lockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            LockUserId = lockUserId;
        }
    }
}
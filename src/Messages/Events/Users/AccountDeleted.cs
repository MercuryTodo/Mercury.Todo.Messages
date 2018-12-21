namespace Messages.Events.Users
{
    public class AccountDeleted : AuthenticatedEvent
    {
        public bool Soft { get; }

        protected AccountDeleted()
        {
        }

        public AccountDeleted(string requestId, string userId, bool soft)
        {
            RequestId = requestId;
            UserId = userId;
            Soft = soft;
        }
    }
}
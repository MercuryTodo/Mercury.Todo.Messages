namespace Messages.Events.Users
{
    public class AccountUnlocked : AuthenticatedEvent
    {
        public string UnlockUserId { get; set; }

        protected AccountUnlocked()
        {
        }

        public AccountUnlocked(string requestId, string userId, string unlockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            UnlockUserId = unlockUserId;
        }
    }
}
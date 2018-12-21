namespace Messages.Events.Users
{
    public class AvatarRemoved : AuthenticatedEvent
    {
        protected AvatarRemoved()
        {
        }

        public AvatarRemoved(string requestId, string userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
namespace Messages.Events.Users
{
    public class AvatarUploaded : AuthenticatedEvent
    {
        public string AvatarUrl { get; }

        protected AvatarUploaded()
        {
        }

        public AvatarUploaded(string requestId, string userId, string avatarUrl)
        {
            RequestId = requestId;
            UserId = userId;
            AvatarUrl = avatarUrl;
        }
    }
}
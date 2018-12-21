namespace Messages.Events.Users
{
    public class PasswordChanged : AuthenticatedEvent
    {
        protected PasswordChanged()
        {
        }

        public PasswordChanged(string requestId, string userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
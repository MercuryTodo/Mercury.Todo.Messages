namespace Messages.Events.Users
{
    public class UsernameChanged : AuthenticatedEvent
    {
        public string NewName { get; }
        public string State { get; }

        protected UsernameChanged()
        {
        }

        public UsernameChanged(string requestId, string userId, string newName, string state)
        {
            RequestId = requestId;
            UserId = userId;
            NewName = newName;
            State = state;
        }
    }
}
namespace Mercury.Todo.Messages.Events.Users
{
    public class SignedIn : BaseEvent
    {
        public string UserId { get; }
        public string Email { get; }
        public string Name { get; }
        public string Provider { get; set; }

        protected SignedIn()
        {
        }

        public SignedIn(string requestId, string userId, string email,
            string name, string provider)
        {
            RequestId = requestId;
            UserId = userId;
            Email = email;
            Name = name;
            Provider = provider;
        }
    }
}
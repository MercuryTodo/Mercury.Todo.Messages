namespace Mercury.Todo.Messages.Events.Users
{
    public class AccountActivated : AuthenticatedEvent
    {
        public string Email { get; set; }

        protected AccountActivated()
        {
        }

        public AccountActivated(string requestId, string email, string userId)
        {
            RequestId = requestId;
            Email = email;
            UserId = userId;
        }
    }
}
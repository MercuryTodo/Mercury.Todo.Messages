namespace Mercury.Todo.Messages.Events.Users
{
    public class ResetPasswordInitiated : BaseEvent
    {
        public string Email { get; }

        protected ResetPasswordInitiated()
        {
        }

        public ResetPasswordInitiated(string requestId, string email)
        {
            RequestId = requestId;
            Email = email;
        }
    }
}
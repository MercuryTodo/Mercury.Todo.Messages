namespace Mercury.Todo.Messages.Events.Users
{
    public class NewPasswordSet : BaseEvent
    {
        public string Email { get; }

        protected NewPasswordSet()
        {
        }

        public NewPasswordSet(string requestId, string email)
        {
            RequestId = requestId;
            Email = email;
        }
    }
}
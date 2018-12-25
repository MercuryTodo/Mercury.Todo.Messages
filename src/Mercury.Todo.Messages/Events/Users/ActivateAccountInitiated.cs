namespace Mercury.Todo.Messages.Events.Users
{
    public class ActivateAccountInitiated : BaseEvent
    {
        public string Email { get; set; }

        protected ActivateAccountInitiated()
        {
        }

        public ActivateAccountInitiated(string requestId, string email)
        {
            RequestId = requestId;
            Email = email;
        }
    }
}
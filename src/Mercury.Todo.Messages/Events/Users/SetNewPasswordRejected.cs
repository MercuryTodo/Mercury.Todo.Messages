namespace Mercury.Todo.Messages.Events.Users
{
    public class SetNewPasswordRejected : RejectedEvent
    {
        public string Email { get; }

        protected SetNewPasswordRejected()
        {
        }

        public SetNewPasswordRejected(string requestId, string code, string reason, string email)
        {
            RequestId = requestId;
            Reason = reason;
            Code = code;
            Email = email;
        }
    }
}
namespace Messages.Events.Users
{
    public class DeleteAccountRejected : RejectedEvent
    {
        protected DeleteAccountRejected()
        {
        }

        public DeleteAccountRejected(string requestId,
            string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}
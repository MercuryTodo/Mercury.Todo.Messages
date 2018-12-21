namespace Messages.Events.Users
{
    public class RemoveAvatarRejected : RejectedEvent
    {
        protected RemoveAvatarRejected()
        {
        }

        public RemoveAvatarRejected(string requestId,
            string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}
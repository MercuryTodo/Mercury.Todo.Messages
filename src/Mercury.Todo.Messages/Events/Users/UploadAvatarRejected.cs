namespace Mercury.Todo.Messages.Events.Users
{
    public class UploadAvatarRejected : RejectedEvent
    {
        protected UploadAvatarRejected()
        {
        }

        public UploadAvatarRejected(string requestId,
            string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}
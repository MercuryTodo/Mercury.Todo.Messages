namespace Messages.Commands.Users
{
    public class LockAccount : AuthenticatedCommand
    {
        public string LockUserId { get; set; }
    }
}
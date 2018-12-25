namespace Mercury.Todo.Messages.Commands.Users
{
    public class UnlockAccount : AuthenticatedCommand
    {
        public string UnlockUserId { get; set; }
    }
}
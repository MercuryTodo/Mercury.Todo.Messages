namespace Mercury.Todo.Messages.Commands
{
    public abstract class AuthenticatedCommand : BaseCommand
    {
        public string UserId { get; set; }
    }
}
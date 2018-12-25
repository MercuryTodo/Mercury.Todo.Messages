namespace Mercury.Todo.Messages.Commands.Users
{
    public class ChangeUsername : AuthenticatedCommand
    {
        public string Name { get; set; }
    }
}
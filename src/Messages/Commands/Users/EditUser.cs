namespace Mercury.Todo.Messages.Commands.Users
{
    public class EditUser : AuthenticatedCommand
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
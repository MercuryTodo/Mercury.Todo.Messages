namespace Mercury.Todo.Messages.Commands.Users
{
    public class SetNewPassword : BaseCommand
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
    }
}
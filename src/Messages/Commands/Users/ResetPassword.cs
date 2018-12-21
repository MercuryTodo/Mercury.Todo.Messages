namespace Messages.Commands.Users
{
    public class ResetPassword : BaseCommand
    {
        public string Email { get; set; }
        public string Endpoint { get; set; }
    }
}
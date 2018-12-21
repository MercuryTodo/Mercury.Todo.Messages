namespace Messages.Commands.Users
{
    public class ActivateAccount : BaseCommand
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
namespace Messages.Commands.Users
{
    public class ChangePassword : AuthenticatedCommand
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
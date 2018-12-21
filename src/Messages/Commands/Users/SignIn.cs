namespace Messages.Commands.Users
{
    public class SignIn : BaseCommand
    {
        public string SessionId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string AccessToken { get; set; }
        public string Provider { get; set; }

        public bool IsInvalid()
        {
            return string.IsNullOrEmpty(SessionId)
                || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(Password)
                || string.IsNullOrEmpty(IpAddress)
                || string.IsNullOrEmpty(UserAgent);
        }
    }
}
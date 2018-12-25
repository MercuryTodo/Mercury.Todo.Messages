namespace Mercury.Todo.Messages.Commands.Users
{
    public class RefreshUserSession : BaseCommand
    {
        public string SessionId { get; set; }
        public string NewSessionId { get; set; }
        public string Key { get; set; }
    }
}
namespace Mercury.Todo.Messages.Commands.Users
{
    public class PostOnFacebookWall : AuthenticatedCommand
    {
        public string AccessToken { get; set; }
        public string Message { get; set; }
    }
}
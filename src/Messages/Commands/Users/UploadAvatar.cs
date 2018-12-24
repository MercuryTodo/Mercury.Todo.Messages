using Mercury.Todo.Messages.Commands.Models;

namespace Mercury.Todo.Messages.Commands.Users
{
    public class UploadAvatar : AuthenticatedCommand
    {
        public File Avatar { get; set; }
    }
}
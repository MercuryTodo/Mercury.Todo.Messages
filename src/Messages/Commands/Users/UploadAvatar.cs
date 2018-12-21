using Messages.Commands.Models;

namespace Messages.Commands.Users
{
    public class UploadAvatar : AuthenticatedCommand
    {
        public File Avatar { get; set; }
    }
}
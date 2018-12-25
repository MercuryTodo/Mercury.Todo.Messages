namespace Mercury.Todo.Messages.Commands
{
    public abstract class FileUploadCommand : AuthenticatedCommand
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public string FileBase64 { get; set; }
    }
}
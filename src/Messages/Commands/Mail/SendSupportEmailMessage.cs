namespace Mercury.Todo.Messages.Commands.Mail
{
    public class SendSupportEmailMessage : SendEmailMessageBase
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
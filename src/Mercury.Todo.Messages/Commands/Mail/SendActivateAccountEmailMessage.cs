namespace Mercury.Todo.Messages.Commands.Mail
{
    public class SendActivateAccountEmailMessage : SendSecuredEmailMessageBase
    {
        public string Username { get; set; }
    }
}
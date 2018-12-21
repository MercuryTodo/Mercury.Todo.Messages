namespace Messages.Commands.Mail
{
    public abstract class SendEmailMessageBase : BaseCommand
    {
        public string Email { get; set; }
    }
}
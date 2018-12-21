namespace Messages.Commands.Mail
{
    public class SendSecuredEmailMessageBase : SendEmailMessageBase
    {
        public string Token { get; set; }
        public string Endpoint { get; set; }
    }
}
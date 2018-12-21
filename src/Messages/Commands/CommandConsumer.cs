namespace Messages.Commands
{
    public abstract class CommandConsumer<T> : BaseConsumer<T> where T : BaseCommand
    {
    }
}
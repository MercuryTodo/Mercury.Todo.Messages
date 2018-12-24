namespace Mercury.Todo.Messages.Commands
{
    public abstract class CommandConsumer<T> : BaseConsumer<T> where T : BaseCommand
    {
    }
}
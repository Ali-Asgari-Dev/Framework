
namespace Framework.Application
{
    public class CommandResult
    {
        public CommandResult()
        {
            
        }

        public CommandResult(object? id)
        {
            Id = id;
        }
        public object? Id { get; set; }
    }
}

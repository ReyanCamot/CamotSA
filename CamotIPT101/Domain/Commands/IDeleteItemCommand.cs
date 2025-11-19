namespace Domain.Commands
{
    public interface IDeleteItemCommand
    {
        Task Execute(int id);
    }
}

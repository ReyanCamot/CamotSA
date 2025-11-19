using Domain.Models;

namespace Domain.Commands
{
    public interface ICreateItemCommand
    {
        Task<Item> Execute(Item item);
    }
}

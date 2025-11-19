using Domain.Models;

namespace Domain.Commands
{
    public interface IUpdateItemCommand
    {
        Task<Item> Execute(Item item);
    }
}

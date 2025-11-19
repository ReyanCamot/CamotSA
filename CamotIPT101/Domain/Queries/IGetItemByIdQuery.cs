using Domain.Models;

namespace Domain.Queries
{
    public interface IGetItemByIdQuery
    {
        Task<Item> Execute(int id);
    }
}

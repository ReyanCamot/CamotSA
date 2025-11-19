using Domain.Models;

namespace Domain.Queries
{
    public interface IGetAllItemsQuery
    {
        Task<IEnumerable<Item>> Execute();
    }
}

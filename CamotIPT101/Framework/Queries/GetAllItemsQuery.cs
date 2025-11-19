using Domain.Models;
using Domain.Queries;
using Microsoft.EntityFrameworkCore;

namespace Framework.Queries
{
    public class GetAllItemsQuery : IGetAllItemsQuery
    {
        private readonly AppDbContextFactory _contextFactory;

        public GetAllItemsQuery(AppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Item>> Execute()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                var itemDtos = await context.Items.ToListAsync();

                return itemDtos.Select(dto => new Item
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Description = dto.Description,
                    Price = dto.Price,
                    Quantity = dto.Quantity,
                    CreatedDate = dto.CreatedDate
                });
            }
        }
    }
}

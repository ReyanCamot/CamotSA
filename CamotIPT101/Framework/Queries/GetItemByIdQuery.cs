using Domain.Models;
using Domain.Queries;

namespace Framework.Queries
{
    public class GetItemByIdQuery : IGetItemByIdQuery
    {
        private readonly AppDbContextFactory _contextFactory;

        public GetItemByIdQuery(AppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Item> Execute(int id)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                var itemDto = await context.Items.FindAsync(id);

                if (itemDto == null)
                    return null;

                return new Item
                {
                    Id = itemDto.Id,
                    Name = itemDto.Name,
                    Description = itemDto.Description,
                    Price = itemDto.Price,
                    Quantity = itemDto.Quantity,
                    CreatedDate = itemDto.CreatedDate
                };
            }
        }
    }
}

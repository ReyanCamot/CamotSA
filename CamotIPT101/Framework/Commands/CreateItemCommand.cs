using Domain.Commands;
using Domain.Models;
using Framework.DTOs;

namespace Framework.Commands
{
    public class CreateItemCommand : ICreateItemCommand
    {
        private readonly AppDbContextFactory _contextFactory;

        public CreateItemCommand(AppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Item> Execute(Item item)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                var itemDto = new ItemDto
                {
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    CreatedDate = DateTime.Now
                };

                context.Items.Add(itemDto);
                await context.SaveChangesAsync();

                item.Id = itemDto.Id;
                item.CreatedDate = itemDto.CreatedDate;

                return item;
            }
        }
    }
}

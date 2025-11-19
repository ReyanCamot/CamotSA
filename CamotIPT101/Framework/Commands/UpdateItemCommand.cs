using Domain.Commands;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Framework.Commands
{
    public class UpdateItemCommand : IUpdateItemCommand
    {
        private readonly AppDbContextFactory _contextFactory;

        public UpdateItemCommand(AppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Item> Execute(Item item)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                var itemDto = await context.Items.FindAsync(item.Id);
                
                if (itemDto == null)
                    throw new Exception("Item not found");

                itemDto.Name = item.Name;
                itemDto.Description = item.Description;
                itemDto.Price = item.Price;
                itemDto.Quantity = item.Quantity;

                await context.SaveChangesAsync();

                return item;
            }
        }
    }
}

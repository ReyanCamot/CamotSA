using Domain.Commands;

namespace Framework.Commands
{
    public class DeleteItemCommand : IDeleteItemCommand
    {
        private readonly AppDbContextFactory _contextFactory;

        public DeleteItemCommand(AppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(int id)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                var itemDto = await context.Items.FindAsync(id);
                
                if (itemDto != null)
                {
                    context.Items.Remove(itemDto);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}

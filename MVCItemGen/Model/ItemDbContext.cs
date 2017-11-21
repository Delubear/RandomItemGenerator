using Microsoft.EntityFrameworkCore;
using RPGItemGenerator.ItemGeneration;

namespace MVCItemGen.Model
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {

        }

        public DbSet<Item> items { get; set; }
    }
}

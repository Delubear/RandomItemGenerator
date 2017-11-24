using Microsoft.EntityFrameworkCore;
using RPGItemGenerator.ItemGeneration;

namespace MVCItemGen.Model
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Armor>();
            builder.Entity<Weapons>();
            builder.Entity<Potions>();
            builder.Entity<Jewelry>();
            builder.Entity<SecondaryProperties>();
            builder.Entity<Ancient>();
            builder.Entity<New>();
            builder.Entity<Old>();
            builder.Entity<Chainmail>();
            builder.Entity<Horned>();
            builder.Entity<Leather>();
            builder.Entity<Platemail>();
            builder.Entity<Acidic>();
            builder.Entity<Bludgeoning>();
            builder.Entity<Fiery>();
            builder.Entity<Freezing>();
            builder.Entity<Lightning>();
            builder.Entity<Piercing>();
            builder.Entity<Slashing>();
            builder.Entity<Deadly>();
            builder.Entity<Dull>();
            builder.Entity<Sharp>();
            builder.Entity<Durable>();
            builder.Entity<Fragile>();
            builder.Entity<Unbreakable>();
            builder.Entity<Iron>();
            builder.Entity<Obsidian>();
            builder.Entity<Steel>();
            builder.Entity<Wooden>();
            builder.Entity<Deadeye>();
            builder.Entity<Focusing>();
            builder.Entity<Strength>();
            builder.Entity<Vitality>();


            base.OnModelCreating(builder);
        }

        public DbSet<Item> items { get; set; }
    }
}

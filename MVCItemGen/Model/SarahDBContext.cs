using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model
{
    public class SarahDBContext : DbContext
    {
        public SarahDBContext(DbContextOptions<SarahDBContext> options) : base(options)
        {

        }

        public SarahDBContext()
        {

        }

        public DbSet<SarahsItem> SarahsItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SarahsItem>();


            base.OnModelCreating(builder);
        }
    }
}

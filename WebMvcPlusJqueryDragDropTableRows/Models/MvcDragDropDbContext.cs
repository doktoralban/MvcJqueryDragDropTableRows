using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvcPlusJqueryDragDropTableRows.Models
{
    public class MvcDragDropDbContext : DbContext
    {

        public MvcDragDropDbContext()
        {
        }

        public MvcDragDropDbContext(DbContextOptions<MvcDragDropDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tbMvcDragDropTableRows> tbMvcDragDropTableRows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}

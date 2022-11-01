using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bunea_Denisa_Lab2.Models;

namespace Bunea_Denisa_Lab2.Data
{
    public class Bunea_Denisa_Lab2Context : DbContext
    {
        public Bunea_Denisa_Lab2Context (DbContextOptions<Bunea_Denisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bunea_Denisa_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bunea_Denisa_Lab2.Models.Author> Author { get; set; }

        public DbSet<Bunea_Denisa_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Bunea_Denisa_Lab2.Models.Category> Category { get; set; }
    }
}

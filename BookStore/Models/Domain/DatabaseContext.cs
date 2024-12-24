using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Domain
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> books { get; set; }


    }
}

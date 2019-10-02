using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Rent> Rents { get; set; }

        public BookContext(DbContextOptions<BookContext> options)
         : base(options)
        {
        }

    }
}

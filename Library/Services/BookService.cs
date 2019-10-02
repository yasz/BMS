using Library.Data;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookService
    {
        private readonly BookContext _context;

        public BookService(BookContext context)
        {
            _context = context;
        }

        public async Task AddRent(string bookId, string vano)
        {
            _context.Rents.Add(new Rent()
            {
                RentId = Guid.NewGuid(),
                BookNo = bookId,
                Vano = vano,
                StartDate = DateTime.UtcNow
            }); ;
            await _context.SaveChangesAsync();
        }
    }
}

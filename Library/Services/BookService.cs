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

        public async Task AddRent(string bookNo, string vano)
        {

            var rentBooksCount = _context.Rents.Where(r => r.Vano == vano && r.EndDate.ToString() == "0001-01-01 00:00:00").Count();
            var records = _context.Rents.Where(r => r.BookNo == bookNo && r.EndDate.ToString() == "0001-01-01 00:00:00");
            try
            {
                if (rentBooksCount >= 2)
                {
                    throw new VAException($"异常002：您已借阅超过两本书籍");
                }
                Rent record = records.Single();
                if (record != null)
                {
                    throw new VAException($"异常001：此书已被{record.Vano}借阅");
                }
            }
            catch (VAException e) { throw e; }
            catch (Exception e) {  }


            _context.Rents.Add(new Rent()
            {
                RentId = Guid.NewGuid(),
                BookNo = bookNo,
                Vano = vano,
                StartDate = DateTime.Now
            }); 
            await _context.SaveChangesAsync();
        }

        public async Task ReturnBook(string bookNo)
        {
            var records = _context.Rents.Where(r => r.BookNo==bookNo && r.EndDate.ToString() == "0001-01-01 00:00:00");
            try { 
                Rent record = records.Single();
                record.EndDate = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            catch (Exception) {
                 throw new Exception("异常101：此书尚未借出，不能归还");
            }

        }
    }
}

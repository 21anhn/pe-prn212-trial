using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;

        public List<Book> GetAll()
        {
            _context = new();

            //Lazy Fetching data -> get all data from db (include FK column)
            return _context.Books.Include(book => book.BookCategory).ToList();
        }
    }
}

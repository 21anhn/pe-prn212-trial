using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public class CategoryRepository
    {
        private BookManagementDbContext _context;

        public List<BookCategory> GetAll()
        {
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}

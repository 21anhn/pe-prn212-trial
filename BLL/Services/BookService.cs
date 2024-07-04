using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories;

namespace BLL.Services
{
    public class BookService
    {
        private BookRepository _bookRepository;

        public List<Book> GetAllBooks()
        {
            _bookRepository = new();
            return _bookRepository.GetAll();
        }
    }
}

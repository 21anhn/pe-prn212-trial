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

        public List<Book> SearchBooksByNameOrDescriptionContaining(string bookName, string description)
        {
            _bookRepository = new();
            return _bookRepository.GetAllBookByBookNameOrDescription(bookName, description);
        }

        public bool CreateBook(Book b)
        {
            _bookRepository = new();
            return _bookRepository.CreateBook(b);  
        }

        public bool DeleteBook(Book b)
        {
            _bookRepository = new();
            return _bookRepository.DeleteBook(b);
        }
    }
}

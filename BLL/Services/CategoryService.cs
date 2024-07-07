using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories;

namespace BLL.Services
{
    public class CategoryService
    {
        private CategoryRepository _categoryRepository = new();

        public List<BookCategory> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }
    }
}

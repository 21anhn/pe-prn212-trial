using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class AirConditionerRepository
    {
        AirConditionerShop2024DbContext _context;

        public List<AirConditioner> GetAll()
        {
            _context = new();
            return _context.AirConditioners.Include("Supplier").ToList();
        }
    }
}

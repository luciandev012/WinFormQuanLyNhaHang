using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Data;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Services
{
    public class CategoryServices
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Data;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Services
{
    public class GoodServices
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        public List<Good> GetListGoodsByCategory(int categoryId)
        {
            return _context.Goods.Where(x => x.CategoryId == categoryId).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Data;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Services
{
    public class TableServices
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        public List<Table> GetListTable()
        {
            return _context.Tables.ToList();
        }
    }
}

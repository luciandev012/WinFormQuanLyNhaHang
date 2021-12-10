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
        public void ChangeStatus(int id)
        {
            var table = _context.Tables.Find(id);
            if(table.Status)
            {
                table.Status = false;
            }
            else
            {
                table.Status = true;
            }
            _context.SaveChanges();
        }
    }
}

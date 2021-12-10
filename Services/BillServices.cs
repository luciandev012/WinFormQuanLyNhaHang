using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Data;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Services
{
    public class BillServices
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        public int Create(string customerName, int userId, int tableId)
        {
            var bill = new Bill()
            {
                CustomerName = customerName,
                IsPaid = false,
                TableId = tableId,
                TimeStamp = DateTime.Now,
                Total = 0,
                UserId = userId
            };
            _context.Bills.Add(bill);
            return _context.SaveChanges();
        }
    }
}

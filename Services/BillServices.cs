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

        public float GetTotal(int tableId)
        {
            return _context.Bills.Where(x => x.TableId == tableId && x.IsPaid == false).Select(x => x.Total).FirstOrDefault();
        }
        public void UpdateTotal(int tableId, float Price)
        {
            var bill = _context.Bills.Where(x => x.TableId == tableId && x.IsPaid == false).FirstOrDefault();

            bill.Total = Price;
            _context.SaveChanges();
        }
        public void Pay(int tableId)
        {
            var bill = _context.Bills.Where(x => x.TableId == tableId && x.IsPaid == false).FirstOrDefault();
            bill.IsPaid = true;
            _context.SaveChanges();
        }
    }
}

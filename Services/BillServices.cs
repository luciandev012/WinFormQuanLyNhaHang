﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Common;
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
        public List<BillVM> GetListBill(DateTime start, DateTime end)
        {
            var query = from b in _context.Bills
                        join u in _context.Users on b.UserId equals u.Id
                        join t in _context.Tables on b.TableId equals t.Id
                        where b.TimeStamp >= start && b.TimeStamp <= end
                        select new { b, u, t };
            var data = query.Select(x => new BillVM()
            {
                TimeStamp = x.b.TimeStamp,
                CustomerName = x.b.CustomerName,
                Table = x.t.Name,
                Total = x.b.Total.ToString(),
                UserName = x.u.Lastname + " " + x.u.FirstName
            }).ToList();

            //var bills = _context.Bills.Where(x => x.TimeStamp > start && x.TimeStamp < end).ToList();
            //var listBillVM = new List<BillVM>();
            return data;
        }
    }
}

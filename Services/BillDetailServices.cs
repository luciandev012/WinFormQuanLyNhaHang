using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Common;
using WinFormQuanLyNhaHang.Data;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Services
{
    public class BillDetailServices
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        public List<BillDetailViewModel> GetBillDetailsByBillId(int tableId)
        {
            var billId = _context.Bills.Where(x => x.TableId == tableId && x.IsPaid == false).Select(x => x.Id).FirstOrDefault();
            var listBill =  _context.BillDetails.Where(x => x.BillId == billId).ToList();
            var listBillVM = new List<BillDetailViewModel>();
            foreach(var item in listBill)
            {
                var good = _context.Goods.Find(item.GoodId);
                var billVM = new BillDetailViewModel()
                {
                    GoodName = good.Name,
                    Count = item.Count,
                    Price = item.Count * good.Price 
                };
                listBillVM.Add(billVM);
            }
            return listBillVM;
        }
        public int Create(int goodId, int tableId)
        {
            var billId = _context.Bills.Where(x => x.TableId == tableId && x.IsPaid == false).Select(x => x.Id).FirstOrDefault();
            
            _context.BillDetails.Add(new BillDetail() { GoodId = goodId, Count = 1, BillId = billId });
            var bill = _context.Bills.Find(billId);
            bill.Total += _context.Goods.Find(goodId).Price;
            return _context.SaveChanges();
        }
        public bool HasGood(int goodId, int tableId)
        {
            var billId = _context.Bills.Where(x => x.TableId == tableId && x.IsPaid == false).Select(x => x.Id).FirstOrDefault();
            var billDetail = _context.BillDetails.Where(x => x.BillId == billId && x.GoodId == goodId).FirstOrDefault();
            return billDetail != null;
        }
        
        public void UpdateCount(int goodId, int tableId)
        {
            var billId = _context.Bills.Where(x => x.TableId == tableId && x.IsPaid == false).Select(x => x.Id).FirstOrDefault();
            var billDetail = _context.BillDetails.Where(x => x.BillId == billId && x.GoodId == goodId).FirstOrDefault();
            billDetail.Count++;
            var bill = _context.Bills.Find(billId);
            bill.Total += _context.Goods.Find(goodId).Price;
            _context.SaveChanges();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Data.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public float Total { get; set; }
        public bool IsPaid { get; set; }
        public string CustomerName { get; set; }
        public int UserId { get; set; }
        //public int BillDetailId { get; set; }
        public int TableId { get; set; }

        public virtual Table Table { get; set; }
        public virtual User User { get; set; }
        public virtual List<BillDetail> BillDetails { get; set; }
    }
}

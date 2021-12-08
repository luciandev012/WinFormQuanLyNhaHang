using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Data.Entities
{
    public class BillDetail
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int Count { get; set; }
        public int BillId { get; set; }
        
        public virtual Bill Bill { get; set; }
    }
}

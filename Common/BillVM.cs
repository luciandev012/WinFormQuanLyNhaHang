using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Common
{
    public class BillVM
    {
        public DateTime TimeStamp { get; set; }
        public string Total { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public string Table { get; set; }
    }
}

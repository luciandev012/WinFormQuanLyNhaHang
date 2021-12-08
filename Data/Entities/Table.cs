using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Data.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}

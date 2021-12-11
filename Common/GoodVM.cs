using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Common
{
    public class GoodVM
    {
        public int Id { get; set; }
        public string GoodName { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public Bitmap Image { get; set; }
        public string CategoryName { get; set; }
    }
}

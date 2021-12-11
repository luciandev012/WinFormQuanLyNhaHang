using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormQuanLyNhaHang.Common;
using WinFormQuanLyNhaHang.Data;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Services
{
    public class GoodServices
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        public List<Good> GetListGoodsByCategory(int categoryId)
        {
            return _context.Goods.Where(x => x.CategoryId == categoryId).ToList();
        }
        public List<GoodVM> GetListGoodVM()
        {
            var query = from g in _context.Goods
                        join c in _context.Categories on g.CategoryId equals c.Id
                        select new { g, c };
            var list = query.ToList();
            var data = new List<GoodVM>();
            foreach(var item in list)
            {
                var goodVM = new GoodVM()
                {
                    Id = item.g.Id,
                    Count = item.g.Count,
                    GoodName = item.g.Name,
                    Price = item.g.Price,
                    CategoryName = item.c.Name,
                    Image = new Bitmap(GetImageDirect(item.g.Image))
                };
                data.Add(goodVM);
            }    
            return data;
        }
        private string GetImageDirect(string image)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", string.Empty);
            var folder = Path.Combine(appPath, @"Asset\Image");
            var path = Path.Combine(folder, image);
            return path;
        }
    }
}

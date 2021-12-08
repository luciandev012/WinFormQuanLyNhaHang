using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Common;
using WinFormQuanLyNhaHang.Data;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Services
{
    public class UserServices
    {
        private RestaurantDbContext _context = new RestaurantDbContext();

        public Response<User> Authenticate(string username, string password)
        {
            var user = _context.Users.Where(x => x.Username == username).FirstOrDefault();
            if(user == null)
            {
                return new Response<User>(false, "Tên đăng nhập không đúng", null);
            }
            if(user.Password != password)
            {
                return new Response<User>(false, "Sai mật khẩu!", null);
            }
            return new Response<User>(true, "Đăng nhập thành công!", user);
        }
    }
}

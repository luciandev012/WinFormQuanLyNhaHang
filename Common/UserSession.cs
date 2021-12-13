using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Common
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; }
        public static string PhoneNumber { get; set; }
        public static int Role { get; set; }
    }
}

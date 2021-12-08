using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Role Role { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}

﻿using System;
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
        public List<UserVM> GetListUser()
        {
            var users = _context.Users.ToList();
            var listUser = new List<UserVM>();
            foreach(var item in users)
            {
                var userVM = new UserVM()
                {
                    Id = item.Id,
                    FullName = item.Lastname + " " + item.FirstName,
                    Username = item.Username
                };
                listUser.Add(userVM);
            }
            return listUser;
        }
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        public bool Create(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges() > 0;
        }
        public bool Edit(User user)
        {
            var u = _context.Users.Find(user.Id);
            u.Password = user.Password;
            u.PhoneNumber = user.PhoneNumber;
            u.Lastname = user.Lastname;
            u.FirstName = user.FirstName;
            return _context.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            return _context.SaveChanges() > 0;
        }
    }
}

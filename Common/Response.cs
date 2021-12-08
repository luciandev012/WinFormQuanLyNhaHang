using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQuanLyNhaHang.Common
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T ResponseObj { get; set; }

        public Response(bool isSuccess, string message, T obj)
        {
            IsSuccess = isSuccess;
            Message = message;
            ResponseObj = obj;
        }
    }
}

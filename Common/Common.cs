using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormQuanLyNhaHang.Common
{
    public static class Common
    {
        public static string GetImageDirect(string image)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", string.Empty);
            var folder = Path.Combine(appPath, @"Asset\Image");
            var path = Path.Combine(folder, image);
            return path;
        }
        public static string GetFolderImage()
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", string.Empty);
            var folder = Path.Combine(appPath, @"Asset\Image");
            return folder;
        }
    }
}

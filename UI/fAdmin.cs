using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormQuanLyNhaHang.Common;
using WinFormQuanLyNhaHang.Services;

namespace WinFormQuanLyNhaHang.UI
{
    public partial class fAdmin : UserControl
    {
        private GoodServices _goodServices;
        public fAdmin()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var list = _goodServices.GetListGoodVM();
            foreach(var item in list)
            {
                dgvGood.Rows.Add(new object[] { item.Id.ToString(), item.GoodName.ToString(), item.Price.ToString(), item.Count.ToString(), item.Image, item.CategoryName });
            }
            
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            _goodServices = new GoodServices();
            LoadData();
        }
    }
}

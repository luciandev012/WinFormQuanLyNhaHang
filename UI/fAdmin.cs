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
        private CategoryServices _categoryServices;
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
            var listCategory = _categoryServices.GetCategories();
            cmbCategory.DataSource = listCategory;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            _goodServices = new GoodServices();
            _categoryServices = new CategoryServices();
            LoadData();
        }

        private void dgvGood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dgvGood.SelectedCells[0].RowIndex;
            var row = dgvGood.Rows[rowIndex];
            txtGoodName.Text = row.Cells[1].Value.ToString();
            txtPrice.Text = row.Cells[2].Value.ToString();
            txtGoodCount.Text = row.Cells[3].Value.ToString();
            cmbCategory.Text = row.Cells[5].Value.ToString();
        }
    }
}

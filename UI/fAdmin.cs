using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string imgName;
        private int goodId;
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
        private void ResetData()
        {
            txtGoodCount.Text = "";
            txtGoodName.Text = "";
            txtPrice.Text = "";
            pictureBox1.Image.Dispose();
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
            goodId = int.Parse(row.Cells[0].Value.ToString());
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
                imgName = Path.GetFileName(imgLocation);
            }    
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            
            var fileName = Path.Combine(Common.Common.GetFolderImage(), imgName);
            pictureBox1.Image.Save(fileName);
            var goodName = txtGoodName.Text;
            var price = int.Parse(txtPrice.Text);
            var count = int.Parse(txtGoodCount.Text);
            var categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            var res = _goodServices.Create(goodName, price, imgName, count, categoryId);
            if(res > 0)
            {
                LoadData();
                ResetData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo");
            }    
        }

        private void btnEditGood_Click(object sender, EventArgs e)
        {
            var fileName = Path.Combine(Common.Common.GetFolderImage(), imgName);
            pictureBox1.Image.Save(fileName);
            var goodName = txtGoodName.Text;
            var price = int.Parse(txtPrice.Text);
            var count = int.Parse(txtGoodCount.Text);
            var categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            var res = _goodServices.Edit(goodName, price, imgName, count, categoryId, goodId);
            if (res > 0)
            {
                LoadData();
                ResetData();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo");
            }
        }

        private void btnDeleteGood_Click(object sender, EventArgs e)
        {
            var res = _goodServices.Delete(goodId);
            if(res > 0)
            {
                LoadData();
                ResetData();
            }   
            else
            {
                MessageBox.Show("Xoá không thành công!", "Thông báo");
            }    
        }
    }
}

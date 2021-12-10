using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormQuanLyNhaHang.Data.Entities;
using WinFormQuanLyNhaHang.Services;

namespace WinFormQuanLyNhaHang.UI
{
    public partial class fAddDrink : Form
    {
        private readonly GoodServices _goodServices = new GoodServices();
        private Good currentFood;
        public List<int> ListGoodId { get; set; }
        private List<int> currentGoodId = new List<int>();
        public fAddDrink()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            var listGood = _goodServices.GetListGoodsByCategory(2);
            foreach (var item in listGood)
            {
                Button btn = new Button() { Width = 200, Height = 200 };
                btn.Text = item.Name + Environment.NewLine + item.Price.ToString();
                btn.Click += Btn_Click;
                btn.Tag = item;

                flpDrink.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            currentFood = (sender as Button).Tag as Good;
            txtDrinkCount.Text = "0";
        }



        private void btnLeft_Click_1(object sender, EventArgs e)
        {
            var count = int.Parse(txtDrinkCount.Text);

            if (currentFood == null)
            {
                MessageBox.Show("Bạn chưa chọn món", "Thông báo");
            }
            if (currentFood != null)
            {
                var currentPrice = int.Parse(lblPrice.Text);
                currentPrice -= currentFood.Price;
                lblPrice.Text = currentPrice.ToString();
                currentGoodId.Remove(currentFood.Id);
                count--;
            }
            txtDrinkCount.Text = count.ToString();
        }

        private void btnRight_Click_1(object sender, EventArgs e)
        {
            var count = int.Parse(txtDrinkCount.Text);

            if (currentFood == null)
            {
                MessageBox.Show("Bạn chưa chọn món", "Thông báo");
            }
            if (currentFood != null)
            {
                var currentPrice = int.Parse(lblPrice.Text);
                currentPrice += currentFood.Price;
                lblPrice.Text = currentPrice.ToString();
                currentGoodId.Add(currentFood.Id);
                count++;
            }
            txtDrinkCount.Text = count.ToString();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ListGoodId = currentGoodId;
            this.Close();
        }
    }
}

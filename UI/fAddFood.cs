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
    public partial class fAddFood : Form
    {
        private readonly GoodServices _goodServices = new GoodServices();
        private Good currentFood;
        public List<int> ListGoodId { get; set; }
        private List<int> currentGoodId = new List<int>();
        public fAddFood()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            var listGood = _goodServices.GetListGoodsByCategory(1);
            foreach(var item in listGood)
            {
                Button btn = new Button() { Width = 200, Height = 200 };
                Panel pnl = new Panel() { Width = 210, Height = 350 };
                Label lbl = new Label() { Width = 200, Height = 120, AutoSize = false };

                lbl.Location = new Point(0, 205);
                lbl.Text = item.Name + Environment.NewLine + item.Price.ToString() + Environment.NewLine + "còn lại: " + item.Count;
                //btn.Text = item.Name + Environment.NewLine + item.Price.ToString() + Environment.NewLine + "còn lại: " + item.Count;
                btn.BackgroundImage = new Bitmap(Common.Common.GetImageDirect(item.Image));
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;
                pnl.Controls.Add(btn);
                pnl.Controls.Add(lbl);
                flpFood.Controls.Add(pnl);
            }    
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            currentFood = (sender as Button).Tag as Good;
            txtFoodCount.Text = "0";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            var count = int.Parse(txtFoodCount.Text);
            
            if(currentFood == null)
            {
                MessageBox.Show("Bạn chưa chọn món", "Thông báo");
            }    
            if(currentFood != null)
            {
                var currentPrice = int.Parse(lblPrice.Text);
                currentPrice -= currentFood.Price;
                lblPrice.Text = currentPrice.ToString();
                currentGoodId.Remove(currentFood.Id);
                count--;
            }    
            txtFoodCount.Text = count.ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            var count = int.Parse(txtFoodCount.Text);
            
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
            txtFoodCount.Text = count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListGoodId = currentGoodId;
            this.Close();
        }
    }
}

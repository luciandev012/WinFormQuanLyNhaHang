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
using WinFormQuanLyNhaHang.Data.Entities;
using WinFormQuanLyNhaHang.Services;

namespace WinFormQuanLyNhaHang.UI
{
    
   
    public partial class fTableMng : UserControl
    {
        private TableServices _tableServices;
        private BillServices _billServices;
        private BillDetailServices _billDetailServices;

        private int tableId = -1;
        private bool tableStatus;
        public fTableMng()
        {

            InitializeComponent();
            
        }

        #region Method
        
      
        public void LoadTable()
        {
            var listTable = _tableServices.GetListTable();
            foreach(var item in listTable)
            {
                Button btn = new Button() { Width = 200, Height = 200 };
                btn.Text = item.Name + Environment.NewLine + (item.Status? "Có người" : "Trống");
                btn.Click += Btn_Click;
                btn.Tag = item;
                if (item.Status)
                {
                    btn.BackColor = Color.Pink;

                }
                else
                {
                    btn.BackColor = Color.AliceBlue;
                }    
                flpTable.Controls.Add(btn);
            }
        }

        public void ResetTable()
        {
            flpTable.Controls.Clear();
        }

        private void ShowBill()
        {
            lsvBill.Items.Clear();
            
            var listBillDetails = _billDetailServices.GetBillDetailsByBillId(tableId);

            foreach(var item in listBillDetails)
            {
                ListViewItem lsvItem = new ListViewItem(item.GoodName);
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvBill.Items.Add(lsvItem);
            }    
        }
        private void UpdateTotal()
        {
            lblTotalPrice.Text =  _billServices.GetTotal(tableId).ToString();
        }
        
        #endregion

        private void Btn_Click(object sender, EventArgs e)
        {
            var table = (sender as Button).Tag as Table;
            lblTableName.Text = table.Name;
            lblTableName.Tag = table.Id;
            tableId = table.Id;
            tableStatus = table.Status;
            ShowBill();
            UpdateTotal();
        }
        private void fTableMng_Load(object sender, EventArgs e)
        {
            _tableServices = new TableServices();
            _billServices = new BillServices();
            _billDetailServices = new BillDetailServices();

            LoadTable();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(tableId < 0)
            {

            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thanh toán số tiền "+lblTotalPrice.Text+"?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _billServices.Pay(tableId);
                    ShowBill();
                    UpdateTotal();
                    _tableServices.ChangeStatus(tableId);
                    ResetTable();
                    LoadTable();
                }
               
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            
            if (!tableStatus)
            {
                MessageBox.Show("Bàn trống chưa được đặt!", "Thông báo");
            }
            else
            {
                fAddFood food = new fAddFood();
                food.ShowDialog();
                var listGoodId = food.ListGoodId;
                if(listGoodId != null)
                {
                    foreach (var item in listGoodId)
                    {
                        if (_billDetailServices.HasGood(item, tableId))
                        {
                            _billDetailServices.UpdateCount(item, tableId);
                        }
                        else
                        {
                            _billDetailServices.Create(item, tableId);
                        }
                    }
                }    
                ShowBill();
                UpdateTotal();
            }
            
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            var userId = UserSession.UserId;
            if(lblTableName.Tag == null || lblTableName.Tag.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo");
            }
            else
            {
                

                CustomerName ctmName = new CustomerName();
                ctmName.ShowDialog();
                
                var customerName = ctmName.CusName;

                var res = _billServices.Create(customerName, userId, tableId);
                if (res > 0)
                {
                    _tableServices.ChangeStatus(tableId);
                }
                ResetTable();
                LoadTable();
            }
        }
    }
}

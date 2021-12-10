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
                    btn.BackColor = Color.Green;
                }    
                flpTable.Controls.Add(btn);
            }
        }

        public void ResetTable()
        {

        }

        #endregion

        private void Btn_Click(object sender, EventArgs e)
        {
            lblTableName.Text = (sender as Table).Name;
            lblTableName.Tag = (sender as Table).Id;
        }
        private void fTableMng_Load(object sender, EventArgs e)
        {
            _tableServices = new TableServices();
            _billServices = new BillServices();
            LoadTable();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var userId = UserSession.UserId;
            var tableId = int.Parse(lblTableName.Tag.ToString());
            var customerName = "Vu Thanh Tung";

            var res = _billServices.Create(customerName, userId, tableId);
            if(res > 0)
            {
                _tableServices.ChangeStatus(tableId);
            }
            LoadTable();
        }
    }
}

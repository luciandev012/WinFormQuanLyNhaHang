using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormQuanLyNhaHang.Services;

namespace WinFormQuanLyNhaHang.UI
{
    public partial class fStatistic : UserControl
    {
        private BillServices _billServices;
        private UserServices _userServices;
        private BillDetailServices _detailServices;
        //private float total = 0;
        public fStatistic()
        {
            InitializeComponent();
        }

        private void fStatistic_Load(object sender, EventArgs e)
        {
            _billServices = new BillServices();
            _userServices = new UserServices();
            _detailServices = new BillDetailServices();
            LoadData();
        }

        private void LoadData()
        {
            var listBill = _billServices.GetListBill(new DateTime(2000, 12, 1), DateTime.Now);
            dgvBill.DataSource = listBill;
            int income = 0;
            foreach(var item in listBill)
            {
                income += int.Parse(item.Total);
            }    
            lblIncome.Text = income.ToString();
            cmbUser.DataSource = _userServices.GetListUser();
            cmbUser.DisplayMember = "FullName";
            cmbUser.ValueMember = "Id";
        }
        

        private void btnLookup_Click(object sender, EventArgs e)
        {
            var start = dtpFrom.Value;
            var end = dtpTo.Value;
            var bills = _billServices.GetListBill(start, end);
            bills = bills.Where(x => x.UserName == cmbUser.Text).ToList();
            dgvBill.DataSource = bills;
            int income = 0;
            foreach (var item in bills)
            {
                income += int.Parse(item.Total);
            }
            lblIncome.Text = income.ToString();
            
        }


       

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvBill.SelectedCells[0].RowIndex;
            var timeStamp = DateTime.Parse(dgvBill.Rows[row].Cells[0].Value.ToString());

            var billDetails = _detailServices.GetBillDetailsByTimestamp(timeStamp);
            dgvBillDetail.DataSource = billDetails;
        }

        
    }
}

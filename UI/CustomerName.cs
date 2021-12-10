using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormQuanLyNhaHang.UI
{
    public partial class CustomerName : Form
    {
        public string CusName { get; set; }
        public CustomerName()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Nhập tên khách hàng", "Thông báo");
            }    
            else
            {
                CusName = txtCustomerName.Text;
                Close();
            }    
        }
    }
}

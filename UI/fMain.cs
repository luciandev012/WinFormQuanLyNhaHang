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

namespace WinFormQuanLyNhaHang.UI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            LoadData();
        }

        #region Method
        public void LoadData()
        {
            lblUserFullname.Text = "Xin chào " + UserSession.FullName + "!";  
        }
        #endregion

        private void btnTableMng_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var table = new fTableMng();
            pnlMain.Controls.Add(table);
        }
    }
}

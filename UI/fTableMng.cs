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
    
   
    public partial class fTableMng : UserControl
    {
        private TableServices _tableServices;
        
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
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.Name + Environment.NewLine + (item.Status? "Có người" : "Trống");
                flpTable.Controls.Add(btn);
            }
        }
        #endregion

        private void fTableMng_Load(object sender, EventArgs e)
        {
            _tableServices = new TableServices();
            LoadTable();
        }
    }
}

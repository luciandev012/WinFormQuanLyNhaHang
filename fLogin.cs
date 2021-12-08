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
using WinFormQuanLyNhaHang.UI;

namespace WinFormQuanLyNhaHang
{

    public partial class fLogin : Form
    {
        private UserServices _userServices = new UserServices(); 
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát?","Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var res = _userServices.Authenticate(username, password);
            if(res.IsSuccess)
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi đăng nhập");
            }
            this.Show();
        }
    }
}

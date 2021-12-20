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
    public partial class fUser : Form
    {
        private readonly UserServices _userServices;
        private int _id;
        public fUser()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void fUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var users = _userServices.GetUsers();
            dgvUser.DataSource = users;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvUser.SelectedCells[0].RowIndex;
            var selectedRow = dgvUser.Rows[row];
            txtUsername.Text = selectedRow.Cells[1].Value.ToString();
            txtPassword.Text = selectedRow.Cells[2].Value.ToString();
            txtPhone.Text = selectedRow.Cells[6].Value.ToString();
            txtFirstName.Text = selectedRow.Cells[4].Value.ToString();
            txtLastName.Text = selectedRow.Cells[5].Value.ToString();
            _id = int.Parse(selectedRow.Cells[0].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin", "Thông báo");
            }
            else
            {
                if(MessageBox.Show("Bạn có muốn thêm tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var user = new User()
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        FirstName = txtFirstName.Text,
                        Lastname = txtLastName.Text,
                        PhoneNumber = txtPhone.Text,
                        RoleId = 2
                    };
                    if (_userServices.Create(user))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }    
                }
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var user = new User()
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        FirstName = txtFirstName.Text,
                        Lastname = txtLastName.Text,
                        PhoneNumber = txtPhone.Text,
                        Id = _id,
                    };
                    if (_userServices.Edit(user))
                    {
                        MessageBox.Show("Sửa thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản "+txtUsername.Text+" không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_userServices.Delete(_id))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }
    }
}

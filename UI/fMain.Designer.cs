
namespace WinFormQuanLyNhaHang.UI
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnTableMng = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnStatistic);
            this.pnlMenu.Controls.Add(this.btnTableMng);
            this.pnlMenu.Location = new System.Drawing.Point(2, 15);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(232, 728);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(243, 15);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1023, 728);
            this.pnlMain.TabIndex = 1;
            // 
            // btnTableMng
            // 
            this.btnTableMng.Location = new System.Drawing.Point(6, 6);
            this.btnTableMng.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTableMng.Name = "btnTableMng";
            this.btnTableMng.Size = new System.Drawing.Size(223, 105);
            this.btnTableMng.TabIndex = 0;
            this.btnTableMng.Text = "Danh sách bàn";
            this.btnTableMng.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(6, 113);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(6);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(223, 105);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Thống kê doanh thu";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(6, 219);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(223, 105);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Quản lý món ăn";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 758);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fMain";
            this.Text = "Phần mềm quản lý nhà hàng";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnTableMng;
        private System.Windows.Forms.Panel pnlMain;
    }
}
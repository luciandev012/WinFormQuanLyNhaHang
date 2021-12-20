
namespace WinFormQuanLyNhaHang.UI
{
    partial class fAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGoodCount = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvGood = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteGood = new System.Windows.Forms.Button();
            this.btnEditGood = new System.Windows.Forms.Button();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanToolStripMenuItem,
            this.quảnLýLoạiMónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanToolStripMenuItem
            // 
            this.quanToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanToolStripMenuItem.Name = "quanToolStripMenuItem";
            this.quanToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.quanToolStripMenuItem.Text = "Quản lý món ăn";
            this.quanToolStripMenuItem.Click += new System.EventHandler(this.quanToolStripMenuItem_Click);
            // 
            // quảnLýLoạiMónToolStripMenuItem
            // 
            this.quảnLýLoạiMónToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýLoạiMónToolStripMenuItem.Name = "quảnLýLoạiMónToolStripMenuItem";
            this.quảnLýLoạiMónToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.quảnLýLoạiMónToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýLoạiMónToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiMónToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvGood);
            this.panel1.Location = new System.Drawing.Point(14, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 572);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cmbCategory);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(3, 475);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(512, 42);
            this.panel7.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(164, 3);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(345, 32);
            this.cmbCategory.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại món";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtGoodCount);
            this.panel6.Location = new System.Drawing.Point(3, 427);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 42);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // txtGoodCount
            // 
            this.txtGoodCount.Location = new System.Drawing.Point(164, 3);
            this.txtGoodCount.Name = "txtGoodCount";
            this.txtGoodCount.Size = new System.Drawing.Size(345, 29);
            this.txtGoodCount.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtPrice);
            this.panel5.Location = new System.Drawing.Point(3, 379);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(512, 42);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(164, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(345, 29);
            this.txtPrice.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtGoodName);
            this.panel4.Location = new System.Drawing.Point(3, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 42);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món:";
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(164, 3);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(345, 29);
            this.txtGoodName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImage);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(521, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 238);
            this.panel3.TabIndex = 1;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(66, 192);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(134, 43);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Chọn ảnh";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvGood
            // 
            this.dgvGood.AllowUserToAddRows = false;
            this.dgvGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GoodName,
            this.Price,
            this.Count,
            this.Image,
            this.CategoryName});
            this.dgvGood.Location = new System.Drawing.Point(3, 3);
            this.dgvGood.Name = "dgvGood";
            this.dgvGood.RowTemplate.Height = 200;
            this.dgvGood.Size = new System.Drawing.Size(773, 322);
            this.dgvGood.TabIndex = 0;
            this.dgvGood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGood_CellClick);
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // GoodName
            // 
            this.GoodName.Frozen = true;
            this.GoodName.HeaderText = "Tên món";
            this.GoodName.Name = "GoodName";
            this.GoodName.Width = 170;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Đơn giá";
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Count
            // 
            this.Count.Frozen = true;
            this.Count.HeaderText = "Số còn lại";
            this.Count.Name = "Count";
            this.Count.Width = 70;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.Frozen = true;
            this.Image.HeaderText = "Ảnh";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.Name = "Image";
            this.Image.Width = 210;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Tên loại";
            this.CategoryName.Name = "CategoryName";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteGood);
            this.panel2.Controls.Add(this.btnEditGood);
            this.panel2.Controls.Add(this.btnAddGood);
            this.panel2.Location = new System.Drawing.Point(801, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 572);
            this.panel2.TabIndex = 2;
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.Location = new System.Drawing.Point(0, 127);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(213, 56);
            this.btnDeleteGood.TabIndex = 0;
            this.btnDeleteGood.Text = "Xoá món";
            this.btnDeleteGood.UseVisualStyleBackColor = true;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // btnEditGood
            // 
            this.btnEditGood.Location = new System.Drawing.Point(0, 65);
            this.btnEditGood.Name = "btnEditGood";
            this.btnEditGood.Size = new System.Drawing.Size(213, 56);
            this.btnEditGood.TabIndex = 0;
            this.btnEditGood.Text = "Sửa món";
            this.btnEditGood.UseVisualStyleBackColor = true;
            this.btnEditGood.Click += new System.EventHandler(this.btnEditGood_Click);
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(0, 3);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(213, 56);
            this.btnAddGood.TabIndex = 0;
            this.btnAddGood.Text = "Thêm món";
            this.btnAddGood.UseVisualStyleBackColor = true;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fAdmin";
            this.Size = new System.Drawing.Size(1023, 728);
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiMónToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvGood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGoodCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.Button btnDeleteGood;
        private System.Windows.Forms.Button btnEditGood;
    }
}


namespace WinFormQuanLyNhaHang.UI
{
    partial class fAddDrink
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
            this.flpDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.txtDrinkCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpDrink
            // 
            this.flpDrink.AutoScroll = true;
            this.flpDrink.Location = new System.Drawing.Point(15, 15);
            this.flpDrink.Margin = new System.Windows.Forms.Padding(6);
            this.flpDrink.Name = "flpDrink";
            this.flpDrink.Size = new System.Drawing.Size(650, 500);
            this.flpDrink.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.txtDrinkCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(677, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(3, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(194, 60);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 59);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::WinFormQuanLyNhaHang.Properties.Resources.icons8_next_page_64;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(139, 63);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 29);
            this.btnRight.TabIndex = 3;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click_1);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::WinFormQuanLyNhaHang.Properties.Resources.icons8_back_to_64;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(19, 63);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 29);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // txtDrinkCount
            // 
            this.txtDrinkCount.Location = new System.Drawing.Point(75, 63);
            this.txtDrinkCount.Name = "txtDrinkCount";
            this.txtDrinkCount.Size = new System.Drawing.Size(58, 29);
            this.txtDrinkCount.TabIndex = 1;
            this.txtDrinkCount.Text = "0";
            this.txtDrinkCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fAddDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpDrink);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fAddDrink";
            this.Text = "fAddDrink";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDrink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox txtDrinkCount;
        private System.Windows.Forms.Label label1;
    }
}
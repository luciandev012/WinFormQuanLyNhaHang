
using System.ComponentModel;

namespace WinFormQuanLyNhaHang.UI
{
    partial class fTableMng
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lblTableName);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.btnAddDrink);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Location = new System.Drawing.Point(718, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 722);
            this.panel2.TabIndex = 1;
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(7, 195);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(277, 40);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.Text = "label1";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(2, 624);
            this.btnPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(277, 92);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrink.Location = new System.Drawing.Point(2, 97);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(277, 92);
            this.btnAddDrink.TabIndex = 0;
            this.btnAddDrink.Text = "Thêm đồ uống";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(2, 5);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(277, 90);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm món ăn";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpTable.Location = new System.Drawing.Point(6, 11);
            this.flpTable.Margin = new System.Windows.Forms.Padding(6);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(710, 722);
            this.flpTable.TabIndex = 2;
            // 
            // fTableMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fTableMng";
            this.Size = new System.Drawing.Size(1008, 738);
            this.Load += new System.EventHandler(this.fTableMng_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Label lblTableName;
    }
}

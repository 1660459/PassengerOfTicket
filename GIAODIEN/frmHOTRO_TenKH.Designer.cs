namespace GIAODIEN
{
    partial class frmHOTRO_TenKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOTRO_TenKH));
            this.dgvTimKH = new System.Windows.Forms.DataGridView();
            this.id_khachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimKH
            // 
            this.dgvTimKH.AllowUserToAddRows = false;
            this.dgvTimKH.AllowUserToDeleteRows = false;
            this.dgvTimKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_khachhang,
            this.hoten});
            this.dgvTimKH.Location = new System.Drawing.Point(2, 78);
            this.dgvTimKH.Name = "dgvTimKH";
            this.dgvTimKH.ReadOnly = true;
            this.dgvTimKH.RowTemplate.Height = 24;
            this.dgvTimKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKH.Size = new System.Drawing.Size(818, 480);
            this.dgvTimKH.TabIndex = 0;
            // 
            // id_khachhang
            // 
            this.id_khachhang.DataPropertyName = "id_khachhang";
            this.id_khachhang.HeaderText = "ID Khách Hàng";
            this.id_khachhang.Name = "id_khachhang";
            this.id_khachhang.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Tên Khách Hàng";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(133, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 22);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Kiếm";
            // 
            // frmHOTRO_TenKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvTimKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHOTRO_TenKH";
            this.Load += new System.EventHandler(this.frmHOTRO_TenKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimKH;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
    }
}
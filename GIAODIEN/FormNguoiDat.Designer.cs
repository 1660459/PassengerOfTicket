namespace GIAODIEN
{
    partial class FormNguoiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNguoiDat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXuatVe = new System.Windows.Forms.Button();
            this.btnXoaNguoiDat = new System.Windows.Forms.Button();
            this.dgvNguoiDat = new System.Windows.Forms.DataGridView();
            this.id_ve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_khach_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghe_id_ghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyen_id_chuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuatve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvNguoiDat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 635);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnXuatVe);
            this.panel3.Controls.Add(this.btnXoaNguoiDat);
            this.panel3.Location = new System.Drawing.Point(4, 414);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1463, 215);
            this.panel3.TabIndex = 9;
            // 
            // btnXuatVe
            // 
            this.btnXuatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXuatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatVe.ForeColor = System.Drawing.Color.White;
            this.btnXuatVe.Location = new System.Drawing.Point(373, 94);
            this.btnXuatVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatVe.Name = "btnXuatVe";
            this.btnXuatVe.Size = new System.Drawing.Size(288, 62);
            this.btnXuatVe.TabIndex = 7;
            this.btnXuatVe.Text = "XUẤT VÉ";
            this.btnXuatVe.UseVisualStyleBackColor = false;
            this.btnXuatVe.Click += new System.EventHandler(this.btnXuatVe_Click);
            // 
            // btnXoaNguoiDat
            // 
            this.btnXoaNguoiDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaNguoiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNguoiDat.ForeColor = System.Drawing.Color.White;
            this.btnXoaNguoiDat.Location = new System.Drawing.Point(852, 94);
            this.btnXoaNguoiDat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNguoiDat.Name = "btnXoaNguoiDat";
            this.btnXoaNguoiDat.Size = new System.Drawing.Size(299, 62);
            this.btnXoaNguoiDat.TabIndex = 8;
            this.btnXoaNguoiDat.Text = "XÓA";
            this.btnXoaNguoiDat.UseVisualStyleBackColor = false;
            this.btnXoaNguoiDat.Click += new System.EventHandler(this.btnXoaNguoiDat_Click);
            // 
            // dgvNguoiDat
            // 
            this.dgvNguoiDat.AllowUserToAddRows = false;
            this.dgvNguoiDat.AllowUserToDeleteRows = false;
            this.dgvNguoiDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiDat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNguoiDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ve,
            this.stt,
            this.ten_khach_hang,
            this.so_dt,
            this.ghe_id_ghe,
            this.chuyen_id_chuyen,
            this.tinhtrang,
            this.giatien,
            this.ngayxuatve,
            this.ghichu});
            this.dgvNguoiDat.Location = new System.Drawing.Point(4, 86);
            this.dgvNguoiDat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNguoiDat.MultiSelect = false;
            this.dgvNguoiDat.Name = "dgvNguoiDat";
            this.dgvNguoiDat.ReadOnly = true;
            this.dgvNguoiDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguoiDat.Size = new System.Drawing.Size(1464, 350);
            this.dgvNguoiDat.TabIndex = 6;
            this.dgvNguoiDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiDat_CellClick);
            // 
            // id_ve
            // 
            this.id_ve.DataPropertyName = "id_ve";
            this.id_ve.HeaderText = "ID Vé";
            this.id_ve.Name = "id_ve";
            this.id_ve.ReadOnly = true;
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "Số Thứ Tự";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // ten_khach_hang
            // 
            this.ten_khach_hang.DataPropertyName = "ten_khach_hang";
            this.ten_khach_hang.HeaderText = "Tên Khách Hàng";
            this.ten_khach_hang.Name = "ten_khach_hang";
            this.ten_khach_hang.ReadOnly = true;
            // 
            // so_dt
            // 
            this.so_dt.DataPropertyName = "so_dt";
            this.so_dt.HeaderText = "Số Điện Thoại";
            this.so_dt.Name = "so_dt";
            this.so_dt.ReadOnly = true;
            // 
            // ghe_id_ghe
            // 
            this.ghe_id_ghe.DataPropertyName = "ghe_id_ghe";
            this.ghe_id_ghe.HeaderText = "Mã Ghế";
            this.ghe_id_ghe.Name = "ghe_id_ghe";
            this.ghe_id_ghe.ReadOnly = true;
            // 
            // chuyen_id_chuyen
            // 
            this.chuyen_id_chuyen.DataPropertyName = "chuyen_id_chuyen";
            this.chuyen_id_chuyen.HeaderText = "Mã Chuyến";
            this.chuyen_id_chuyen.Name = "chuyen_id_chuyen";
            this.chuyen_id_chuyen.ReadOnly = true;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình Trạng";
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.ReadOnly = true;
            // 
            // giatien
            // 
            this.giatien.DataPropertyName = "giatien";
            this.giatien.HeaderText = "Giá Tiền";
            this.giatien.Name = "giatien";
            this.giatien.ReadOnly = true;
            // 
            // ngayxuatve
            // 
            this.ngayxuatve.DataPropertyName = "ngayxuatve";
            this.ngayxuatve.HeaderText = "Ngày Xuất Vé";
            this.ngayxuatve.Name = "ngayxuatve";
            this.ngayxuatve.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 75);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1395, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(508, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH VÉ ĐÃ ĐẶT";
            // 
            // FormNguoiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 639);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNguoiDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNguoiDat";
            this.Load += new System.EventHandler(this.FormNguoiDat_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaNguoiDat;
        private System.Windows.Forms.Button btnXuatVe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.DataGridView dgvNguoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ve;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_khach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghe_id_ghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyen_id_chuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuatve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;

    }
}
namespace GIAODIEN
{
    partial class FormQLChuyenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLChuyenXe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaChuyenXe = new System.Windows.Forms.Button();
            this.btnSuaChuyenXe = new System.Windows.Forms.Button();
            this.dgvChuyenXe = new System.Windows.Forms.DataGridView();
            this.id_chuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuyen_id_tuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giokhoihanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xe_xeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tai_xe_id_taixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenXe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvChuyenXe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnXoaChuyenXe);
            this.panel3.Controls.Add(this.btnSuaChuyenXe);
            this.panel3.Location = new System.Drawing.Point(3, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 150);
            this.panel3.TabIndex = 10;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(200, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaChuyenXe
            // 
            this.btnXoaChuyenXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaChuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChuyenXe.ForeColor = System.Drawing.Color.White;
            this.btnXoaChuyenXe.Location = new System.Drawing.Point(742, 68);
            this.btnXoaChuyenXe.Name = "btnXoaChuyenXe";
            this.btnXoaChuyenXe.Size = new System.Drawing.Size(182, 41);
            this.btnXoaChuyenXe.TabIndex = 8;
            this.btnXoaChuyenXe.Text = "XÓA";
            this.btnXoaChuyenXe.UseVisualStyleBackColor = false;
            this.btnXoaChuyenXe.Click += new System.EventHandler(this.btnXoaChuyenXe_Click);
            // 
            // btnSuaChuyenXe
            // 
            this.btnSuaChuyenXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaChuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChuyenXe.ForeColor = System.Drawing.Color.White;
            this.btnSuaChuyenXe.Location = new System.Drawing.Point(463, 68);
            this.btnSuaChuyenXe.Name = "btnSuaChuyenXe";
            this.btnSuaChuyenXe.Size = new System.Drawing.Size(199, 41);
            this.btnSuaChuyenXe.TabIndex = 9;
            this.btnSuaChuyenXe.Text = "SỬA";
            this.btnSuaChuyenXe.UseVisualStyleBackColor = false;
            this.btnSuaChuyenXe.Click += new System.EventHandler(this.btnSuaChuyenXe_Click);
            // 
            // dgvChuyenXe
            // 
            this.dgvChuyenXe.AllowUserToAddRows = false;
            this.dgvChuyenXe.AllowUserToDeleteRows = false;
            this.dgvChuyenXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenXe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_chuyen,
            this.tuyen_id_tuyen,
            this.giokhoihanh,
            this.ghichu,
            this.xe_xeid,
            this.tai_xe_id_taixe});
            this.dgvChuyenXe.Location = new System.Drawing.Point(3, 59);
            this.dgvChuyenXe.MultiSelect = false;
            this.dgvChuyenXe.Name = "dgvChuyenXe";
            this.dgvChuyenXe.ReadOnly = true;
            this.dgvChuyenXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenXe.Size = new System.Drawing.Size(1095, 295);
            this.dgvChuyenXe.TabIndex = 6;
            this.dgvChuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenXe_CellClick);
            // 
            // id_chuyen
            // 
            this.id_chuyen.DataPropertyName = "id_chuyen";
            this.id_chuyen.HeaderText = "ID";
            this.id_chuyen.Name = "id_chuyen";
            this.id_chuyen.ReadOnly = true;
            // 
            // tuyen_id_tuyen
            // 
            this.tuyen_id_tuyen.DataPropertyName = "tuyen_id_tuyen";
            this.tuyen_id_tuyen.HeaderText = "Tuyến";
            this.tuyen_id_tuyen.Name = "tuyen_id_tuyen";
            this.tuyen_id_tuyen.ReadOnly = true;
            // 
            // giokhoihanh
            // 
            this.giokhoihanh.DataPropertyName = "giokhoihanh";
            this.giokhoihanh.HeaderText = "Giờ Khởi Hành";
            this.giokhoihanh.Name = "giokhoihanh";
            this.giokhoihanh.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // xe_xeid
            // 
            this.xe_xeid.DataPropertyName = "xe_xeid";
            this.xe_xeid.HeaderText = "ID Xe";
            this.xe_xeid.Name = "xe_xeid";
            this.xe_xeid.ReadOnly = true;
            // 
            // tai_xe_id_taixe
            // 
            this.tai_xe_id_taixe.DataPropertyName = "tai_xe_id_taixe";
            this.tai_xe_id_taixe.HeaderText = "ID Tài Xế";
            this.tai_xe_id_taixe.Name = "tai_xe_id_taixe";
            this.tai_xe_id_taixe.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 53);
            this.panel2.TabIndex = 5;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1038, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(282, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC CHUYẾN XE ĐANG HOẠT ĐỘNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormQLChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLChuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuyenXecs";
            this.Load += new System.EventHandler(this.FormQLChuyenXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenXe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuaChuyenXe;
        private System.Windows.Forms.Button btnXoaChuyenXe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvChuyenXe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_chuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuyen_id_tuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn giokhoihanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn xe_xeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tai_xe_id_taixe;

    }
}
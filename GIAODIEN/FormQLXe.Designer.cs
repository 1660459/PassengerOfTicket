namespace GIAODIEN
{
    partial class FormQLXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLXe));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDanhSachXe = new System.Windows.Forms.DataGridView();
            this.xe_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_dang_ky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaixe_id_loaixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaDSXe = new System.Windows.Forms.Button();
            this.btnSuaDSXe = new System.Windows.Forms.Button();
            this.btnThemDSXe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dgvDanhSachXe);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(5, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1455, 422);
            this.panel3.TabIndex = 5;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1405, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDanhSachXe
            // 
            this.dgvDanhSachXe.AllowUserToAddRows = false;
            this.dgvDanhSachXe.AllowUserToDeleteRows = false;
            this.dgvDanhSachXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachXe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xe_id,
            this.ten_xe,
            this.so_dang_ky,
            this.loaixe_id_loaixe});
            this.dgvDanhSachXe.Location = new System.Drawing.Point(-1, 71);
            this.dgvDanhSachXe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachXe.Name = "dgvDanhSachXe";
            this.dgvDanhSachXe.ReadOnly = true;
            this.dgvDanhSachXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachXe.Size = new System.Drawing.Size(1460, 351);
            this.dgvDanhSachXe.TabIndex = 1;
            this.dgvDanhSachXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachXe_CellClick);
            // 
            // xe_id
            // 
            this.xe_id.DataPropertyName = "xe_id";
            this.xe_id.HeaderText = "ID";
            this.xe_id.Name = "xe_id";
            this.xe_id.ReadOnly = true;
            // 
            // ten_xe
            // 
            this.ten_xe.DataPropertyName = "ten_xe";
            this.ten_xe.HeaderText = "Tên Xe";
            this.ten_xe.Name = "ten_xe";
            this.ten_xe.ReadOnly = true;
            // 
            // so_dang_ky
            // 
            this.so_dang_ky.DataPropertyName = "so_dang_ky";
            this.so_dang_ky.HeaderText = "Số Đăng Ký";
            this.so_dang_ky.Name = "so_dang_ky";
            this.so_dang_ky.ReadOnly = true;
            // 
            // loaixe_id_loaixe
            // 
            this.loaixe_id_loaixe.DataPropertyName = "loaixe_id_loaixe";
            this.loaixe_id_loaixe.HeaderText = "ID Loại Xe";
            this.loaixe_id_loaixe.Name = "loaixe_id_loaixe";
            this.loaixe_id_loaixe.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH CÁC XE";
            // 
            // btnXoaDSXe
            // 
            this.btnXoaDSXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDSXe.ForeColor = System.Drawing.Color.Red;
            this.btnXoaDSXe.Location = new System.Drawing.Point(605, 25);
            this.btnXoaDSXe.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDSXe.Name = "btnXoaDSXe";
            this.btnXoaDSXe.Size = new System.Drawing.Size(260, 48);
            this.btnXoaDSXe.TabIndex = 10;
            this.btnXoaDSXe.Text = "XÓA";
            this.btnXoaDSXe.UseVisualStyleBackColor = true;
            this.btnXoaDSXe.Click += new System.EventHandler(this.btnXoaDSXe_Click);
            // 
            // btnSuaDSXe
            // 
            this.btnSuaDSXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDSXe.ForeColor = System.Drawing.Color.Red;
            this.btnSuaDSXe.Location = new System.Drawing.Point(951, 25);
            this.btnSuaDSXe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaDSXe.Name = "btnSuaDSXe";
            this.btnSuaDSXe.Size = new System.Drawing.Size(260, 48);
            this.btnSuaDSXe.TabIndex = 9;
            this.btnSuaDSXe.Text = "SỬA";
            this.btnSuaDSXe.UseVisualStyleBackColor = true;
            this.btnSuaDSXe.Click += new System.EventHandler(this.btnSuaDSXe_Click);
            // 
            // btnThemDSXe
            // 
            this.btnThemDSXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDSXe.ForeColor = System.Drawing.Color.Red;
            this.btnThemDSXe.Location = new System.Drawing.Point(273, 25);
            this.btnThemDSXe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDSXe.Name = "btnThemDSXe";
            this.btnThemDSXe.Size = new System.Drawing.Size(237, 48);
            this.btnThemDSXe.TabIndex = 8;
            this.btnThemDSXe.Text = "THÊM";
            this.btnThemDSXe.UseVisualStyleBackColor = true;
            this.btnThemDSXe.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSuaDSXe);
            this.panel1.Controls.Add(this.btnThemDSXe);
            this.panel1.Controls.Add(this.btnXoaDSXe);
            this.panel1.Location = new System.Drawing.Point(5, 432);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 112);
            this.panel1.TabIndex = 6;
            // 
            // FormQLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1465, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQLXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLXe";
            this.Load += new System.EventHandler(this.FormQLXe_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDanhSachXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaDSXe;
        private System.Windows.Forms.Button btnSuaDSXe;
        private System.Windows.Forms.Button btnThemDSXe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xe_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_dang_ky;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaixe_id_loaixe;
    }
}
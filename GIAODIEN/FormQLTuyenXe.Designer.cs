﻿namespace GIAODIEN
{
    partial class FormQLTuyenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLTuyenXe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuaQLTuyenXe = new System.Windows.Forms.Button();
            this.btnThemQLTuyenXe = new System.Windows.Forms.Button();
            this.btnXoaQLTuyenXe = new System.Windows.Forms.Button();
            this.dgvQLTuyenXe = new System.Windows.Forms.DataGridView();
            this.id_tuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoang_cach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianchay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tram_id_tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tram_id_tram1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTuyenXe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvQLTuyenXe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 432);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSuaQLTuyenXe);
            this.panel3.Controls.Add(this.btnThemQLTuyenXe);
            this.panel3.Controls.Add(this.btnXoaQLTuyenXe);
            this.panel3.Location = new System.Drawing.Point(3, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 72);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSuaQLTuyenXe
            // 
            this.btnSuaQLTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaQLTuyenXe.ForeColor = System.Drawing.Color.Red;
            this.btnSuaQLTuyenXe.Location = new System.Drawing.Point(433, 13);
            this.btnSuaQLTuyenXe.Name = "btnSuaQLTuyenXe";
            this.btnSuaQLTuyenXe.Size = new System.Drawing.Size(199, 41);
            this.btnSuaQLTuyenXe.TabIndex = 12;
            this.btnSuaQLTuyenXe.Text = "SỬA";
            this.btnSuaQLTuyenXe.UseVisualStyleBackColor = true;
            this.btnSuaQLTuyenXe.Click += new System.EventHandler(this.btnSuaQLTuyenXe_Click);
            // 
            // btnThemQLTuyenXe
            // 
            this.btnThemQLTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemQLTuyenXe.ForeColor = System.Drawing.Color.Red;
            this.btnThemQLTuyenXe.Location = new System.Drawing.Point(181, 13);
            this.btnThemQLTuyenXe.Name = "btnThemQLTuyenXe";
            this.btnThemQLTuyenXe.Size = new System.Drawing.Size(195, 41);
            this.btnThemQLTuyenXe.TabIndex = 10;
            this.btnThemQLTuyenXe.Text = "THÊM";
            this.btnThemQLTuyenXe.UseVisualStyleBackColor = true;
            this.btnThemQLTuyenXe.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaQLTuyenXe
            // 
            this.btnXoaQLTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaQLTuyenXe.ForeColor = System.Drawing.Color.Red;
            this.btnXoaQLTuyenXe.Location = new System.Drawing.Point(727, 13);
            this.btnXoaQLTuyenXe.Name = "btnXoaQLTuyenXe";
            this.btnXoaQLTuyenXe.Size = new System.Drawing.Size(182, 41);
            this.btnXoaQLTuyenXe.TabIndex = 11;
            this.btnXoaQLTuyenXe.Text = "XÓA";
            this.btnXoaQLTuyenXe.UseVisualStyleBackColor = true;
            this.btnXoaQLTuyenXe.Click += new System.EventHandler(this.btnXoaQLTuyenXe_Click);
            // 
            // dgvQLTuyenXe
            // 
            this.dgvQLTuyenXe.AllowUserToAddRows = false;
            this.dgvQLTuyenXe.AllowUserToDeleteRows = false;
            this.dgvQLTuyenXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLTuyenXe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLTuyenXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tuyen,
            this.khoang_cach,
            this.thoigianchay,
            this.tram_id_tram,
            this.tram_id_tram1});
            this.dgvQLTuyenXe.Location = new System.Drawing.Point(3, 59);
            this.dgvQLTuyenXe.MultiSelect = false;
            this.dgvQLTuyenXe.Name = "dgvQLTuyenXe";
            this.dgvQLTuyenXe.ReadOnly = true;
            this.dgvQLTuyenXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLTuyenXe.Size = new System.Drawing.Size(1093, 299);
            this.dgvQLTuyenXe.TabIndex = 1;
            this.dgvQLTuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLTuyenXe_CellClick);
            // 
            // id_tuyen
            // 
            this.id_tuyen.DataPropertyName = "id_tuyen";
            this.id_tuyen.HeaderText = "ID";
            this.id_tuyen.Name = "id_tuyen";
            this.id_tuyen.ReadOnly = true;
            // 
            // khoang_cach
            // 
            this.khoang_cach.DataPropertyName = "khoang_cach";
            this.khoang_cach.HeaderText = "Khoảng Cách";
            this.khoang_cach.Name = "khoang_cach";
            this.khoang_cach.ReadOnly = true;
            // 
            // thoigianchay
            // 
            this.thoigianchay.DataPropertyName = "thoigianchay";
            this.thoigianchay.HeaderText = "Thời Gian Chạy";
            this.thoigianchay.Name = "thoigianchay";
            this.thoigianchay.ReadOnly = true;
            // 
            // tram_id_tram
            // 
            this.tram_id_tram.DataPropertyName = "tram_id_tram";
            this.tram_id_tram.HeaderText = "Trạm 1";
            this.tram_id_tram.Name = "tram_id_tram";
            this.tram_id_tram.ReadOnly = true;
            // 
            // tram_id_tram1
            // 
            this.tram_id_tram1.DataPropertyName = "tram_id_tram1";
            this.tram_id_tram1.HeaderText = "Trạm 2";
            this.tram_id_tram1.Name = "tram_id_tram1";
            this.tram_id_tram1.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 56);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1056, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÍ TUYẾN XE";
            // 
            // FormQLTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLTuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLTuyenXe";
            this.Load += new System.EventHandler(this.FormQLTuyenXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTuyenXe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQLTuyenXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaQLTuyenXe;
        private System.Windows.Forms.Button btnXoaQLTuyenXe;
        private System.Windows.Forms.Button btnThemQLTuyenXe;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoang_cach;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianchay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tram_id_tram;
        private System.Windows.Forms.DataGridViewTextBoxColumn tram_id_tram1;
    }
}
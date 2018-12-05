namespace GIAODIEN
{
    partial class FormQLGiaVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLGiaVe));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDanhSachGiaVe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuaDSXe = new System.Windows.Forms.Button();
            this.btnThemDSXe = new System.Windows.Forms.Button();
            this.btnXoaDSXe = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaVe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dgvDanhSachGiaVe);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 344);
            this.panel3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(981, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Thoat);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1054, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvDanhSachGiaVe
            // 
            this.dgvDanhSachGiaVe.AllowUserToAddRows = false;
            this.dgvDanhSachGiaVe.AllowUserToDeleteRows = false;
            this.dgvDanhSachGiaVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachGiaVe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachGiaVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiaVe.Location = new System.Drawing.Point(5, 58);
            this.dgvDanhSachGiaVe.Name = "dgvDanhSachGiaVe";
            this.dgvDanhSachGiaVe.ReadOnly = true;
            this.dgvDanhSachGiaVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachGiaVe.Size = new System.Drawing.Size(1038, 285);
            this.dgvDanhSachGiaVe.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(367, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH GIÁ VÉ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSuaDSXe);
            this.panel1.Controls.Add(this.btnThemDSXe);
            this.panel1.Controls.Add(this.btnXoaDSXe);
            this.panel1.Location = new System.Drawing.Point(2, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 91);
            this.panel1.TabIndex = 7;
            // 
            // btnSuaDSXe
            // 
            this.btnSuaDSXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaDSXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDSXe.ForeColor = System.Drawing.Color.White;
            this.btnSuaDSXe.Location = new System.Drawing.Point(713, 20);
            this.btnSuaDSXe.Name = "btnSuaDSXe";
            this.btnSuaDSXe.Size = new System.Drawing.Size(180, 39);
            this.btnSuaDSXe.TabIndex = 9;
            this.btnSuaDSXe.Text = "SỬA";
            this.btnSuaDSXe.UseVisualStyleBackColor = false;
            // 
            // btnThemDSXe
            // 
            this.btnThemDSXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemDSXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDSXe.ForeColor = System.Drawing.Color.White;
            this.btnThemDSXe.Location = new System.Drawing.Point(205, 20);
            this.btnThemDSXe.Name = "btnThemDSXe";
            this.btnThemDSXe.Size = new System.Drawing.Size(178, 39);
            this.btnThemDSXe.TabIndex = 8;
            this.btnThemDSXe.Text = "THÊM";
            this.btnThemDSXe.UseVisualStyleBackColor = false;
            this.btnThemDSXe.Click += new System.EventHandler(this.Them_GiaVe);
            // 
            // btnXoaDSXe
            // 
            this.btnXoaDSXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaDSXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDSXe.ForeColor = System.Drawing.Color.White;
            this.btnXoaDSXe.Location = new System.Drawing.Point(454, 20);
            this.btnXoaDSXe.Name = "btnXoaDSXe";
            this.btnXoaDSXe.Size = new System.Drawing.Size(185, 39);
            this.btnXoaDSXe.TabIndex = 10;
            this.btnXoaDSXe.Text = "XÓA";
            this.btnXoaDSXe.UseVisualStyleBackColor = false;
            // 
            // FormQLGiaVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1045, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLGiaVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLGiaVe";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaVe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDanhSachGiaVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuaDSXe;
        private System.Windows.Forms.Button btnThemDSXe;
        private System.Windows.Forms.Button btnXoaDSXe;
    }
}
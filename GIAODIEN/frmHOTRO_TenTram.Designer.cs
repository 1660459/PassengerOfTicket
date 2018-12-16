namespace GIAODIEN
{
    partial class frmHOTRO_TenTram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOTRO_TenTram));
            this.dgvTraCuuTram = new System.Windows.Forms.DataGridView();
            this.id_tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuTram)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTraCuuTram
            // 
            this.dgvTraCuuTram.AllowUserToAddRows = false;
            this.dgvTraCuuTram.AllowUserToDeleteRows = false;
            this.dgvTraCuuTram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraCuuTram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuTram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tram,
            this.ten_tram,
            this.dia_diem});
            this.dgvTraCuuTram.Location = new System.Drawing.Point(-3, 76);
            this.dgvTraCuuTram.Name = "dgvTraCuuTram";
            this.dgvTraCuuTram.ReadOnly = true;
            this.dgvTraCuuTram.RowTemplate.Height = 24;
            this.dgvTraCuuTram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraCuuTram.Size = new System.Drawing.Size(790, 504);
            this.dgvTraCuuTram.TabIndex = 1;
            // 
            // id_tram
            // 
            this.id_tram.DataPropertyName = "id_tram";
            this.id_tram.HeaderText = "ID TRẠM";
            this.id_tram.Name = "id_tram";
            this.id_tram.ReadOnly = true;
            // 
            // ten_tram
            // 
            this.ten_tram.DataPropertyName = "ten_tram";
            this.ten_tram.HeaderText = "Tên Trạm";
            this.ten_tram.Name = "ten_tram";
            this.ten_tram.ReadOnly = true;
            // 
            // dia_diem
            // 
            this.dia_diem.DataPropertyName = "dia_diem";
            this.dia_diem.HeaderText = "Địa Điểm";
            this.dia_diem.Name = "dia_diem";
            this.dia_diem.ReadOnly = true;
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(119, 28);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(315, 22);
            this.txtTraCuu.TabIndex = 2;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tra Cứu";
            // 
            // frmHOTRO_TenTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.dgvTraCuuTram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHOTRO_TenTram";
            this.Load += new System.EventHandler(this.frmHOTRO_TenTram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuTram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTraCuuTram;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_tram;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_diem;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label label1;
    }
}
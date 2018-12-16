namespace GIAODIEN
{
    partial class frmHOTRO_Tuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOTRO_Tuyen));
            this.dgvTimTuyen = new System.Windows.Forms.DataGridView();
            this.id_tuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoang_cach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianchay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tram_id_tram1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tram_id_tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimTuyen
            // 
            this.dgvTimTuyen.AllowUserToAddRows = false;
            this.dgvTimTuyen.AllowUserToDeleteRows = false;
            this.dgvTimTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimTuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tuyen,
            this.khoang_cach,
            this.thoigianchay,
            this.tram_id_tram1,
            this.tram_id_tram});
            this.dgvTimTuyen.Location = new System.Drawing.Point(3, 2);
            this.dgvTimTuyen.Name = "dgvTimTuyen";
            this.dgvTimTuyen.ReadOnly = true;
            this.dgvTimTuyen.RowTemplate.Height = 24;
            this.dgvTimTuyen.Size = new System.Drawing.Size(910, 619);
            this.dgvTimTuyen.TabIndex = 1;
            // 
            // id_tuyen
            // 
            this.id_tuyen.DataPropertyName = "id_tuyen";
            this.id_tuyen.HeaderText = "ID Tuyến";
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
            // tram_id_tram1
            // 
            this.tram_id_tram1.DataPropertyName = "tram_id_tram1";
            this.tram_id_tram1.HeaderText = "Trạm 1";
            this.tram_id_tram1.Name = "tram_id_tram1";
            this.tram_id_tram1.ReadOnly = true;
            // 
            // tram_id_tram
            // 
            this.tram_id_tram.DataPropertyName = "tram_id_tram";
            this.tram_id_tram.HeaderText = "Trạm 2";
            this.tram_id_tram.Name = "tram_id_tram";
            this.tram_id_tram.ReadOnly = true;
            // 
            // frmHOTRO_Tuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 624);
            this.Controls.Add(this.dgvTimTuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHOTRO_Tuyen";
            this.Load += new System.EventHandler(this.frmHOTRO_Tuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimTuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoang_cach;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianchay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tram_id_tram1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tram_id_tram;
    }
}
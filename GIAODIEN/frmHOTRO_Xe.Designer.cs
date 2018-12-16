namespace GIAODIEN
{
    partial class frmHOTRO_Xe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOTRO_Xe));
            this.dgvTraCuuChuyen = new System.Windows.Forms.DataGridView();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xe_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuChuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTraCuuChuyen
            // 
            this.dgvTraCuuChuyen.AllowUserToAddRows = false;
            this.dgvTraCuuChuyen.AllowUserToDeleteRows = false;
            this.dgvTraCuuChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraCuuChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuChuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xe_id,
            this.ten_xe,
            this.tenloai});
            this.dgvTraCuuChuyen.Location = new System.Drawing.Point(1, 78);
            this.dgvTraCuuChuyen.Name = "dgvTraCuuChuyen";
            this.dgvTraCuuChuyen.ReadOnly = true;
            this.dgvTraCuuChuyen.RowTemplate.Height = 24;
            this.dgvTraCuuChuyen.Size = new System.Drawing.Size(844, 453);
            this.dgvTraCuuChuyen.TabIndex = 0;
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(120, 24);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(249, 22);
            this.txtTraCuu.TabIndex = 1;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tra Cứu";
            // 
            // xe_id
            // 
            this.xe_id.DataPropertyName = "xe_id";
            this.xe_id.HeaderText = "ID Xe";
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
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Loại Xe";
            this.tenloai.Name = "tenloai";
            this.tenloai.ReadOnly = true;
            // 
            // frmHOTRO_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.dgvTraCuuChuyen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHOTRO_Xe";
            this.Load += new System.EventHandler(this.frmHOTRO_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuChuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTraCuuChuyen;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xe_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
    }
}
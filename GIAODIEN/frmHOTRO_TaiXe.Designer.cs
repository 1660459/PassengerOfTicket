namespace GIAODIEN
{
    partial class frmHOTRO_TaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOTRO_TaiXe));
            this.dgvTraCuu = new System.Windows.Forms.DataGridView();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_taixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentaixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banglai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.AllowUserToAddRows = false;
            this.dgvTraCuu.AllowUserToDeleteRows = false;
            this.dgvTraCuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_taixe,
            this.tentaixe,
            this.banglai});
            this.dgvTraCuu.Location = new System.Drawing.Point(2, 95);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.ReadOnly = true;
            this.dgvTraCuu.RowTemplate.Height = 24;
            this.dgvTraCuu.Size = new System.Drawing.Size(865, 540);
            this.dgvTraCuu.TabIndex = 0;
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(126, 34);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(333, 22);
            this.txtTraCuu.TabIndex = 1;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tra Cứu";
            // 
            // id_taixe
            // 
            this.id_taixe.DataPropertyName = "id_taixe";
            this.id_taixe.HeaderText = "ID Tài Xế";
            this.id_taixe.Name = "id_taixe";
            this.id_taixe.ReadOnly = true;
            // 
            // tentaixe
            // 
            this.tentaixe.DataPropertyName = "tentaixe";
            this.tentaixe.HeaderText = "Họ Tên Tài Xế";
            this.tentaixe.Name = "tentaixe";
            this.tentaixe.ReadOnly = true;
            // 
            // banglai
            // 
            this.banglai.DataPropertyName = "banglai";
            this.banglai.HeaderText = "Bằng Lái";
            this.banglai.Name = "banglai";
            this.banglai.ReadOnly = true;
            // 
            // frmHOTRO_TaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.dgvTraCuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHOTRO_TaiXe";
            this.Text = "frmHOTRO_TaiXe";
            this.Load += new System.EventHandler(this.frmHOTRO_TaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTraCuu;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_taixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentaixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn banglai;
    }
}
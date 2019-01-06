namespace GIAODIEN
{
    partial class CRView_DoanhThuChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRView_DoanhThuChuyen));
            this.label1 = new System.Windows.Forms.Label();
            this.cbChuyenXe = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRV_CX = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Chuyến";
            // 
            // cbChuyenXe
            // 
            this.cbChuyenXe.FormattingEnabled = true;
            this.cbChuyenXe.Location = new System.Drawing.Point(132, 27);
            this.cbChuyenXe.Name = "cbChuyenXe";
            this.cbChuyenXe.Size = new System.Drawing.Size(310, 24);
            this.cbChuyenXe.TabIndex = 22;
            this.cbChuyenXe.SelectedIndexChanged += new System.EventHandler(this.cbChuyenXe_SelectedIndexChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(748, 88);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(77, 27);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dpKetThuc
            // 
            this.dpKetThuc.Location = new System.Drawing.Point(477, 89);
            this.dpKetThuc.Name = "dpKetThuc";
            this.dpKetThuc.Size = new System.Drawing.Size(246, 22);
            this.dpKetThuc.TabIndex = 19;
            // 
            // dpBatDau
            // 
            this.dpBatDau.Location = new System.Drawing.Point(132, 89);
            this.dpBatDau.Name = "dpBatDau";
            this.dpBatDau.Size = new System.Drawing.Size(246, 22);
            this.dpBatDau.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đến Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Từ Ngày";
            // 
            // CRV_CX
            // 
            this.CRV_CX.ActiveViewIndex = -1;
            this.CRV_CX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_CX.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_CX.DisplayStatusBar = false;
            this.CRV_CX.DisplayToolbar = false;
            this.CRV_CX.Location = new System.Drawing.Point(10, 131);
            this.CRV_CX.Name = "CRV_CX";
            this.CRV_CX.Size = new System.Drawing.Size(869, 470);
            this.CRV_CX.TabIndex = 16;
            this.CRV_CX.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // CRView_DoanhThuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChuyenXe);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dpKetThuc);
            this.Controls.Add(this.dpBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CRV_CX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRView_DoanhThuChuyen";
            this.Load += new System.EventHandler(this.CRView_DoanhThuChuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChuyenXe;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dpKetThuc;
        private System.Windows.Forms.DateTimePicker dpBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_CX;
    }
}
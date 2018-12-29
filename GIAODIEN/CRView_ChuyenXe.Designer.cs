namespace GIAODIEN
{
    partial class CRView_ChuyenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRView_ChuyenXe));
            this.CRV_CX = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbTuyenXe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CRV_CX
            // 
            this.CRV_CX.ActiveViewIndex = -1;
            this.CRV_CX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_CX.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_CX.DisplayStatusBar = false;
            this.CRV_CX.DisplayToolbar = false;
            this.CRV_CX.Location = new System.Drawing.Point(2, 123);
            this.CRV_CX.Name = "CRV_CX";
            this.CRV_CX.Size = new System.Drawing.Size(869, 445);
            this.CRV_CX.TabIndex = 0;
            this.CRV_CX.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbTuyenXe
            // 
            this.cbTuyenXe.FormattingEnabled = true;
            this.cbTuyenXe.Location = new System.Drawing.Point(110, 25);
            this.cbTuyenXe.Name = "cbTuyenXe";
            this.cbTuyenXe.Size = new System.Drawing.Size(310, 24);
            this.cbTuyenXe.TabIndex = 1;
            this.cbTuyenXe.SelectedIndexChanged += new System.EventHandler(this.cbTuyenXe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tuyến Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ Ngày";
            // 
            // dpBatDau
            // 
            this.dpBatDau.Location = new System.Drawing.Point(110, 74);
            this.dpBatDau.Name = "dpBatDau";
            this.dpBatDau.Size = new System.Drawing.Size(246, 22);
            this.dpBatDau.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến Ngày";
            // 
            // dpKetThuc
            // 
            this.dpKetThuc.Location = new System.Drawing.Point(455, 74);
            this.dpKetThuc.Name = "dpKetThuc";
            this.dpKetThuc.Size = new System.Drawing.Size(246, 22);
            this.dpKetThuc.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(726, 73);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // CRView_ChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 572);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dpKetThuc);
            this.Controls.Add(this.dpBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTuyenXe);
            this.Controls.Add(this.CRV_CX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRView_ChuyenXe";
            this.Load += new System.EventHandler(this.CRView_ChuyenXe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_CX;
        private System.Windows.Forms.ComboBox cbTuyenXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpKetThuc;
        private System.Windows.Forms.Button btnTim;
    }
}
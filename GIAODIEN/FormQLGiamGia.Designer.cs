namespace GIAODIEN
{
    partial class FormQLGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLGiamGia));
            this.btn5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Azure;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn5.Location = new System.Drawing.Point(2, 1);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(196, 150);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5%";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(141, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(321, 51);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Azure;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn10.Location = new System.Drawing.Point(216, 1);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(196, 150);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "10%";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.Azure;
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn15.Location = new System.Drawing.Point(428, 1);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(196, 150);
            this.btn15.TabIndex = 0;
            this.btn15.Text = "15%";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // FormQLGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 247);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLGiamGia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn15;
    }
}
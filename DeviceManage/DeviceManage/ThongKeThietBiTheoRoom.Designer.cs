namespace DeviceManage
{
    partial class ThongKeThietBiTheoRoom
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
            this.cbNameRom = new System.Windows.Forms.ComboBox();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.rptThietbiTheoPhong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNameRom
            // 
            this.cbNameRom.FormattingEnabled = true;
            this.cbNameRom.Location = new System.Drawing.Point(134, 39);
            this.cbNameRom.Name = "cbNameRom";
            this.cbNameRom.Size = new System.Drawing.Size(184, 28);
            this.cbNameRom.TabIndex = 6;
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemThongKe.BackColor = System.Drawing.Color.Lime;
            this.btnXemThongKe.Location = new System.Drawing.Point(851, 29);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(153, 33);
            this.btnXemThongKe.TabIndex = 5;
            this.btnXemThongKe.Text = "Xem Thống Kê";
            this.btnXemThongKe.UseVisualStyleBackColor = false;
            this.btnXemThongKe.Click += new System.EventHandler(this.btnXemThongKe_Click);
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(34, 42);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(94, 20);
            this.lblTenPhong.TabIndex = 4;
            this.lblTenPhong.Text = "Tên Phòng :";
            // 
            // rptThietbiTheoPhong
            // 
            this.rptThietbiTheoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptThietbiTheoPhong.DocumentMapWidth = 34;
            this.rptThietbiTheoPhong.Location = new System.Drawing.Point(0, 83);
            this.rptThietbiTheoPhong.Name = "rptThietbiTheoPhong";
            this.rptThietbiTheoPhong.ServerReport.BearerToken = null;
            this.rptThietbiTheoPhong.Size = new System.Drawing.Size(1096, 365);
            this.rptThietbiTheoPhong.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNameRom);
            this.groupBox1.Controls.Add(this.lblTenPhong);
            this.groupBox1.Controls.Add(this.btnXemThongKe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Phòng";
            // 
            // ThongKeThietBiTheoRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptThietbiTheoPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ThongKeThietBiTheoRoom";
            this.Text = "ThongKeThietBiTheoRoom";
            this.Load += new System.EventHandler(this.ThongKeThietBiTheoRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbNameRom;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.Label lblTenPhong;
        private Microsoft.Reporting.WinForms.ReportViewer rptThietbiTheoPhong;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
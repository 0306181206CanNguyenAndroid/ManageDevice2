﻿namespace DeviceManage
{
    partial class reportThietBiTheoPhong
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
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.rptThietbiTheoPhong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbNameRom = new System.Windows.Forms.ComboBox();
            this.grbNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(302, 38);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(94, 20);
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "Tên Phòng :";
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.BackColor = System.Drawing.Color.Lime;
            this.btnXemThongKe.Location = new System.Drawing.Point(746, 25);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(153, 33);
            this.btnXemThongKe.TabIndex = 2;
            this.btnXemThongKe.Text = "Xem Thống Kê";
            this.btnXemThongKe.UseVisualStyleBackColor = false;
            // 
            // grbNhap
            // 
            this.grbNhap.Controls.Add(this.cbNameRom);
            this.grbNhap.Controls.Add(this.btnXemThongKe);
            this.grbNhap.Controls.Add(this.lblTenPhong);
            this.grbNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNhap.Location = new System.Drawing.Point(0, 0);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Size = new System.Drawing.Size(1152, 90);
            this.grbNhap.TabIndex = 3;
            this.grbNhap.TabStop = false;
            this.grbNhap.Text = " Thông Tin Phòng";
            // 
            // rptThietbiTheoPhong
            // 
            this.rptThietbiTheoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptThietbiTheoPhong.DocumentMapWidth = 34;
            this.rptThietbiTheoPhong.Location = new System.Drawing.Point(0, 90);
            this.rptThietbiTheoPhong.Name = "rptThietbiTheoPhong";
            this.rptThietbiTheoPhong.ServerReport.BearerToken = null;
            this.rptThietbiTheoPhong.Size = new System.Drawing.Size(1152, 492);
            this.rptThietbiTheoPhong.TabIndex = 4;
            // 
            // cbNameRom
            // 
            this.cbNameRom.FormattingEnabled = true;
            this.cbNameRom.Location = new System.Drawing.Point(435, 30);
            this.cbNameRom.Name = "cbNameRom";
            this.cbNameRom.Size = new System.Drawing.Size(184, 28);
            this.cbNameRom.TabIndex = 3;
            // 
            // reportThietBiTheoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 582);
            this.Controls.Add(this.rptThietbiTheoPhong);
            this.Controls.Add(this.grbNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportThietBiTheoPhong";
            this.Text = "reportThietBiTheoPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportThietBiTheoPhong_Load);
            this.grbNhap.ResumeLayout(false);
            this.grbNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.GroupBox grbNhap;
        private Microsoft.Reporting.WinForms.ReportViewer rptThietbiTheoPhong;
        private System.Windows.Forms.ComboBox cbNameRom;
    }
}
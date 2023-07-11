namespace DeviceManage
{
    partial class reportNhapThietBiTheoNgay
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemNhapThietBiTheoNgay = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rptThongKeNhapThietBiTheoNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemNhapThietBiTheoNgay);
            this.groupBox1.Controls.Add(this.dtDenNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTuNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Ngày:";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(138, 50);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(152, 26);
            this.dtTuNgay.TabIndex = 1;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(407, 50);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(152, 26);
            this.dtDenNgay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến Ngày:";
            // 
            // btnXemNhapThietBiTheoNgay
            // 
            this.btnXemNhapThietBiTheoNgay.BackColor = System.Drawing.Color.Transparent;
            this.btnXemNhapThietBiTheoNgay.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnXemNhapThietBiTheoNgay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXemNhapThietBiTheoNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemNhapThietBiTheoNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemNhapThietBiTheoNgay.Location = new System.Drawing.Point(653, 36);
            this.btnXemNhapThietBiTheoNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemNhapThietBiTheoNgay.Name = "btnXemNhapThietBiTheoNgay";
            this.btnXemNhapThietBiTheoNgay.Size = new System.Drawing.Size(80, 40);
            this.btnXemNhapThietBiTheoNgay.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnXemNhapThietBiTheoNgay, "Xem Thống Kê");
            this.btnXemNhapThietBiTheoNgay.UseVisualStyleBackColor = false;
            this.btnXemNhapThietBiTheoNgay.Click += new System.EventHandler(this.btnXemNhapThietBiTheoNgay_Click);
            // 
            // rptThongKeNhapThietBiTheoNgay
            // 
            this.rptThongKeNhapThietBiTheoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptThongKeNhapThietBiTheoNgay.Location = new System.Drawing.Point(0, 111);
            this.rptThongKeNhapThietBiTheoNgay.Name = "rptThongKeNhapThietBiTheoNgay";
            this.rptThongKeNhapThietBiTheoNgay.ServerReport.BearerToken = null;
            this.rptThongKeNhapThietBiTheoNgay.Size = new System.Drawing.Size(800, 339);
            this.rptThongKeNhapThietBiTheoNgay.TabIndex = 1;
            // 
            // reportNhapThietBiTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptThongKeNhapThietBiTheoNgay);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportNhapThietBiTheoNgay";
            this.Text = "reportNhapThietBiTheoNgay";
            this.Load += new System.EventHandler(this.reportNhapThietBiTheoNgay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemNhapThietBiTheoNgay;
        private System.Windows.Forms.ToolTip toolTip1;
        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeNhapThietBiTheoNgay;
    }
}
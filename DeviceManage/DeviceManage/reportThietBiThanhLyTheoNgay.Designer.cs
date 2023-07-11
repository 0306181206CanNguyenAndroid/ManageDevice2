namespace DeviceManage
{
    partial class reportThietBiThanhLyTheoNgay
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
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXemThietBiThanhLyTheoNgay = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rptThietBiThanhLyTheoNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemThietBiThanhLyTheoNgay);
            this.groupBox1.Controls.Add(this.dtDenNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtTuNgay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Ngày";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(148, 49);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(166, 26);
            this.dtTuNgay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến Ngày:";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(459, 48);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(166, 26);
            this.dtDenNgay.TabIndex = 3;
            // 
            // btnXemThietBiThanhLyTheoNgay
            // 
            this.btnXemThietBiThanhLyTheoNgay.BackColor = System.Drawing.Color.Transparent;
            this.btnXemThietBiThanhLyTheoNgay.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnXemThietBiThanhLyTheoNgay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXemThietBiThanhLyTheoNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThietBiThanhLyTheoNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemThietBiThanhLyTheoNgay.Location = new System.Drawing.Point(719, 34);
            this.btnXemThietBiThanhLyTheoNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemThietBiThanhLyTheoNgay.Name = "btnXemThietBiThanhLyTheoNgay";
            this.btnXemThietBiThanhLyTheoNgay.Size = new System.Drawing.Size(80, 40);
            this.btnXemThietBiThanhLyTheoNgay.TabIndex = 19;
            this.btnXemThietBiThanhLyTheoNgay.UseVisualStyleBackColor = false;
            this.btnXemThietBiThanhLyTheoNgay.Click += new System.EventHandler(this.btnXemThietBiThanhLyTheoNgay_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Xem Thống Kê";
            // 
            // rptThietBiThanhLyTheoNgay
            // 
            this.rptThietBiThanhLyTheoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptThietBiThanhLyTheoNgay.DocumentMapWidth = 56;
            this.rptThietBiThanhLyTheoNgay.Location = new System.Drawing.Point(0, 100);
            this.rptThietBiThanhLyTheoNgay.Name = "rptThietBiThanhLyTheoNgay";
            this.rptThietBiThanhLyTheoNgay.ServerReport.BearerToken = null;
            this.rptThietBiThanhLyTheoNgay.Size = new System.Drawing.Size(1178, 494);
            this.rptThietBiThanhLyTheoNgay.TabIndex = 1;
            // 
            // reportThietBiThanhLyTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 594);
            this.Controls.Add(this.rptThietBiThanhLyTheoNgay);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportThietBiThanhLyTheoNgay";
            this.Text = "reportThietBiThanhLyTheoNgay";
            this.Load += new System.EventHandler(this.reportThietBiThanhLyTheoNgay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Button btnXemThietBiThanhLyTheoNgay;
        private System.Windows.Forms.ToolTip toolTip1;
        private Microsoft.Reporting.WinForms.ReportViewer rptThietBiThanhLyTheoNgay;
    }
}
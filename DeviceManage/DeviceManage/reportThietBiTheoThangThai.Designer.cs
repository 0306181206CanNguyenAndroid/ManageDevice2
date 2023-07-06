namespace DeviceManage
{
    partial class reportThietBiTheoThangThai
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
            this.gbTrangThai = new System.Windows.Forms.GroupBox();
            this.rdError = new System.Windows.Forms.RadioButton();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.btnXemTKTheoTrangThai = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrangThai
            // 
            this.gbTrangThai.Controls.Add(this.btnXemTKTheoTrangThai);
            this.gbTrangThai.Controls.Add(this.rdNormal);
            this.gbTrangThai.Controls.Add(this.rdError);
            this.gbTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTrangThai.Location = new System.Drawing.Point(0, 0);
            this.gbTrangThai.Name = "gbTrangThai";
            this.gbTrangThai.Size = new System.Drawing.Size(971, 110);
            this.gbTrangThai.TabIndex = 0;
            this.gbTrangThai.TabStop = false;
            this.gbTrangThai.Text = "Trạng Thái";
            // 
            // rdError
            // 
            this.rdError.AutoSize = true;
            this.rdError.Location = new System.Drawing.Point(159, 46);
            this.rdError.Name = "rdError";
            this.rdError.Size = new System.Drawing.Size(130, 24);
            this.rdError.TabIndex = 0;
            this.rdError.TabStop = true;
            this.rdError.Text = "Thiết Bị Hỏng";
            this.rdError.UseVisualStyleBackColor = true;
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Location = new System.Drawing.Point(390, 46);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(124, 24);
            this.rdNormal.TabIndex = 1;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Bình Thường";
            this.rdNormal.UseVisualStyleBackColor = true;
            // 
            // btnXemTKTheoTrangThai
            // 
            this.btnXemTKTheoTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.btnXemTKTheoTrangThai.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnXemTKTheoTrangThai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXemTKTheoTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTKTheoTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemTKTheoTrangThai.Location = new System.Drawing.Point(603, 30);
            this.btnXemTKTheoTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemTKTheoTrangThai.Name = "btnXemTKTheoTrangThai";
            this.btnXemTKTheoTrangThai.Size = new System.Drawing.Size(121, 40);
            this.btnXemTKTheoTrangThai.TabIndex = 18;
            this.btnXemTKTheoTrangThai.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Xem Thống Kê";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(971, 511);
            this.reportViewer1.TabIndex = 1;
            // 
            // reportThietBiTheoThangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 621);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbTrangThai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportThietBiTheoThangThai";
            this.Text = "reportThietBiTheoThangThai";
            this.Load += new System.EventHandler(this.reportThietBiTheoThangThai_Load);
            this.gbTrangThai.ResumeLayout(false);
            this.gbTrangThai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrangThai;
        private System.Windows.Forms.RadioButton rdError;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.Button btnXemTKTheoTrangThai;
        private System.Windows.Forms.ToolTip toolTip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
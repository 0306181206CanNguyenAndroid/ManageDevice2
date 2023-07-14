namespace DeviceManage
{
    partial class frmQuanLyThanhLy
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
            this.lblThanhLy = new System.Windows.Forms.Label();
            this.gbTTThanhLy = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemThanhLy = new System.Windows.Forms.TextBox();
            this.btnTimKiemThanhLy = new System.Windows.Forms.Button();
            this.btbXoaThanhLy = new System.Windows.Forms.Button();
            this.btnThemThanhLy = new System.Windows.Forms.Button();
            this.txtNguoiPhuTrach = new System.Windows.Forms.TextBox();
            this.lblNguoiPhuTrach = new System.Windows.Forms.Label();
            this.dtNgayThanhLy = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThanhLy = new System.Windows.Forms.Label();
            this.cbTenTBThanhLy = new System.Windows.Forms.ComboBox();
            this.lblTenTbThanhLy = new System.Windows.Forms.Label();
            this.dgvThanhLy = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbTTThanhLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhLy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThanhLy
            // 
            this.lblThanhLy.AutoSize = true;
            this.lblThanhLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThanhLy.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblThanhLy.Location = new System.Drawing.Point(0, 0);
            this.lblThanhLy.Name = "lblThanhLy";
            this.lblThanhLy.Size = new System.Drawing.Size(393, 60);
            this.lblThanhLy.TabIndex = 0;
            this.lblThanhLy.Text = "Quản Lý Thanh Lý";
            // 
            // gbTTThanhLy
            // 
            this.gbTTThanhLy.Controls.Add(this.label1);
            this.gbTTThanhLy.Controls.Add(this.txtTimKiemThanhLy);
            this.gbTTThanhLy.Controls.Add(this.btnTimKiemThanhLy);
            this.gbTTThanhLy.Controls.Add(this.btbXoaThanhLy);
            this.gbTTThanhLy.Controls.Add(this.btnThemThanhLy);
            this.gbTTThanhLy.Controls.Add(this.txtNguoiPhuTrach);
            this.gbTTThanhLy.Controls.Add(this.lblNguoiPhuTrach);
            this.gbTTThanhLy.Controls.Add(this.dtNgayThanhLy);
            this.gbTTThanhLy.Controls.Add(this.lblNgayThanhLy);
            this.gbTTThanhLy.Controls.Add(this.cbTenTBThanhLy);
            this.gbTTThanhLy.Controls.Add(this.lblTenTbThanhLy);
            this.gbTTThanhLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTTThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbTTThanhLy.Location = new System.Drawing.Point(0, 60);
            this.gbTTThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTThanhLy.Name = "gbTTThanhLy";
            this.gbTTThanhLy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTThanhLy.Size = new System.Drawing.Size(1293, 225);
            this.gbTTThanhLy.TabIndex = 1;
            this.gbTTThanhLy.TabStop = false;
            this.gbTTThanhLy.Text = "Thông tin thanh lý thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // txtTimKiemThanhLy
            // 
            this.txtTimKiemThanhLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemThanhLy.Location = new System.Drawing.Point(183, 34);
            this.txtTimKiemThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemThanhLy.Name = "txtTimKiemThanhLy";
            this.txtTimKiemThanhLy.Size = new System.Drawing.Size(206, 31);
            this.txtTimKiemThanhLy.TabIndex = 0;
            // 
            // btnTimKiemThanhLy
            // 
            this.btnTimKiemThanhLy.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemThanhLy.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemThanhLy.Location = new System.Drawing.Point(405, 35);
            this.btnTimKiemThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemThanhLy.Name = "btnTimKiemThanhLy";
            this.btnTimKiemThanhLy.Size = new System.Drawing.Size(82, 31);
            this.btnTimKiemThanhLy.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnTimKiemThanhLy, "Tìm Kiếm");
            this.btnTimKiemThanhLy.UseVisualStyleBackColor = false;
            // 
            // btbXoaThanhLy
            // 
            this.btbXoaThanhLy.BackColor = System.Drawing.Color.Transparent;
            this.btbXoaThanhLy.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btbXoaThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbXoaThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbXoaThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btbXoaThanhLy.Location = new System.Drawing.Point(1095, 103);
            this.btbXoaThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbXoaThanhLy.Name = "btbXoaThanhLy";
            this.btbXoaThanhLy.Size = new System.Drawing.Size(122, 40);
            this.btbXoaThanhLy.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btbXoaThanhLy, "Xóa");
            this.btbXoaThanhLy.UseVisualStyleBackColor = false;
            // 
            // btnThemThanhLy
            // 
            this.btnThemThanhLy.BackColor = System.Drawing.Color.Transparent;
            this.btnThemThanhLy.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemThanhLy.Location = new System.Drawing.Point(1095, 35);
            this.btnThemThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThanhLy.Name = "btnThemThanhLy";
            this.btnThemThanhLy.Size = new System.Drawing.Size(122, 40);
            this.btnThemThanhLy.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnThemThanhLy, "Thêm Mới");
            this.btnThemThanhLy.UseVisualStyleBackColor = false;
            // 
            // txtNguoiPhuTrach
            // 
            this.txtNguoiPhuTrach.Location = new System.Drawing.Point(672, 78);
            this.txtNguoiPhuTrach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNguoiPhuTrach.Name = "txtNguoiPhuTrach";
            this.txtNguoiPhuTrach.Size = new System.Drawing.Size(206, 31);
            this.txtNguoiPhuTrach.TabIndex = 11;
            // 
            // lblNguoiPhuTrach
            // 
            this.lblNguoiPhuTrach.AutoSize = true;
            this.lblNguoiPhuTrach.Location = new System.Drawing.Point(515, 82);
            this.lblNguoiPhuTrach.Name = "lblNguoiPhuTrach";
            this.lblNguoiPhuTrach.Size = new System.Drawing.Size(110, 25);
            this.lblNguoiPhuTrach.TabIndex = 10;
            this.lblNguoiPhuTrach.Text = "Người Lập :";
            // 
            // dtNgayThanhLy
            // 
            this.dtNgayThanhLy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThanhLy.Location = new System.Drawing.Point(672, 35);
            this.dtNgayThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayThanhLy.Name = "dtNgayThanhLy";
            this.dtNgayThanhLy.Size = new System.Drawing.Size(206, 31);
            this.dtNgayThanhLy.TabIndex = 9;
            // 
            // lblNgayThanhLy
            // 
            this.lblNgayThanhLy.AutoSize = true;
            this.lblNgayThanhLy.Location = new System.Drawing.Point(515, 40);
            this.lblNgayThanhLy.Name = "lblNgayThanhLy";
            this.lblNgayThanhLy.Size = new System.Drawing.Size(149, 25);
            this.lblNgayThanhLy.TabIndex = 8;
            this.lblNgayThanhLy.Text = "Ngày Thanh Lý :";
            // 
            // cbTenTBThanhLy
            // 
            this.cbTenTBThanhLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenTBThanhLy.FormattingEnabled = true;
            this.cbTenTBThanhLy.Location = new System.Drawing.Point(183, 76);
            this.cbTenTBThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenTBThanhLy.Name = "cbTenTBThanhLy";
            this.cbTenTBThanhLy.Size = new System.Drawing.Size(206, 33);
            this.cbTenTBThanhLy.TabIndex = 5;
            // 
            // lblTenTbThanhLy
            // 
            this.lblTenTbThanhLy.AutoSize = true;
            this.lblTenTbThanhLy.Location = new System.Drawing.Point(39, 86);
            this.lblTenTbThanhLy.Name = "lblTenTbThanhLy";
            this.lblTenTbThanhLy.Size = new System.Drawing.Size(128, 25);
            this.lblTenTbThanhLy.TabIndex = 1;
            this.lblTenTbThanhLy.Text = "Tên Thiết  Bị :";
            // 
            // dgvThanhLy
            // 
            this.dgvThanhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThanhLy.Location = new System.Drawing.Point(0, 285);
            this.dgvThanhLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThanhLy.Name = "dgvThanhLy";
            this.dgvThanhLy.RowHeadersWidth = 62;
            this.dgvThanhLy.RowTemplate.Height = 33;
            this.dgvThanhLy.Size = new System.Drawing.Size(1293, 350);
            this.dgvThanhLy.TabIndex = 2;
            // 
            // frmQuanLyThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 646);
            this.Controls.Add(this.dgvThanhLy);
            this.Controls.Add(this.gbTTThanhLy);
            this.Controls.Add(this.lblThanhLy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyThanhLy";
            this.Text = "frmQuanLyThanhLy";
            this.Load += new System.EventHandler(this.frmQuanLyThanhLy_Load);
            this.gbTTThanhLy.ResumeLayout(false);
            this.gbTTThanhLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThanhLy;
        private System.Windows.Forms.GroupBox gbTTThanhLy;
        private System.Windows.Forms.Label lblTenTbThanhLy;
        private System.Windows.Forms.Label lblNgayThanhLy;
        private System.Windows.Forms.ComboBox cbTenTBThanhLy;
        private System.Windows.Forms.TextBox txtNguoiPhuTrach;
        private System.Windows.Forms.Label lblNguoiPhuTrach;
        private System.Windows.Forms.DateTimePicker dtNgayThanhLy;
        private System.Windows.Forms.Button btbXoaThanhLy;
        private System.Windows.Forms.Button btnThemThanhLy;
        private System.Windows.Forms.Button btnTimKiemThanhLy;
        private System.Windows.Forms.TextBox txtTimKiemThanhLy;
        private System.Windows.Forms.DataGridView dgvThanhLy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}
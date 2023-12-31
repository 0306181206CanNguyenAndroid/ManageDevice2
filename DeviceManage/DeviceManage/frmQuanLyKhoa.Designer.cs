﻿namespace DeviceManage
{
    partial class frmQuanLyKhoa
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
            this.lblQlKhoa = new System.Windows.Forms.Label();
            this.gbTTKhoa = new System.Windows.Forms.GroupBox();
            this.rtbKhoa = new System.Windows.Forms.RichTextBox();
            this.lblMota = new System.Windows.Forms.Label();
            this.gbTimKiemKhoa = new System.Windows.Forms.GroupBox();
            this.btnTimKiemKhoa = new System.Windows.Forms.Button();
            this.txtTimKiemKhoa = new System.Windows.Forms.TextBox();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.dgvQlKhoa = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTTKhoa.SuspendLayout();
            this.gbTimKiemKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQlKhoa
            // 
            this.lblQlKhoa.AutoSize = true;
            this.lblQlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQlKhoa.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblQlKhoa.Location = new System.Drawing.Point(0, 0);
            this.lblQlKhoa.Name = "lblQlKhoa";
            this.lblQlKhoa.Size = new System.Drawing.Size(261, 50);
            this.lblQlKhoa.TabIndex = 0;
            this.lblQlKhoa.Text = "Quản Lý Khoa";
            // 
            // gbTTKhoa
            // 
            this.gbTTKhoa.Controls.Add(this.rtbKhoa);
            this.gbTTKhoa.Controls.Add(this.lblMota);
            this.gbTTKhoa.Controls.Add(this.gbTimKiemKhoa);
            this.gbTTKhoa.Controls.Add(this.btnXoaKhoa);
            this.gbTTKhoa.Controls.Add(this.btnSuaKhoa);
            this.gbTTKhoa.Controls.Add(this.btnThemKhoa);
            this.gbTTKhoa.Controls.Add(this.txtTenKhoa);
            this.gbTTKhoa.Controls.Add(this.lblTenKhoa);
            this.gbTTKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTTKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbTTKhoa.Location = new System.Drawing.Point(0, 50);
            this.gbTTKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTKhoa.Name = "gbTTKhoa";
            this.gbTTKhoa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTKhoa.Size = new System.Drawing.Size(1196, 162);
            this.gbTTKhoa.TabIndex = 1;
            this.gbTTKhoa.TabStop = false;
            this.gbTTKhoa.Text = "Thông tin khoa";
            // 
            // rtbKhoa
            // 
            this.rtbKhoa.Location = new System.Drawing.Point(138, 74);
            this.rtbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbKhoa.Name = "rtbKhoa";
            this.rtbKhoa.Size = new System.Drawing.Size(182, 60);
            this.rtbKhoa.TabIndex = 2;
            this.rtbKhoa.Text = "";
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Location = new System.Drawing.Point(18, 74);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(61, 20);
            this.lblMota.TabIndex = 7;
            this.lblMota.Text = "Mô Tả :";
            // 
            // gbTimKiemKhoa
            // 
            this.gbTimKiemKhoa.Controls.Add(this.btnTimKiemKhoa);
            this.gbTimKiemKhoa.Controls.Add(this.txtTimKiemKhoa);
            this.gbTimKiemKhoa.Location = new System.Drawing.Point(640, 40);
            this.gbTimKiemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimKiemKhoa.Name = "gbTimKiemKhoa";
            this.gbTimKiemKhoa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimKiemKhoa.Size = new System.Drawing.Size(516, 93);
            this.gbTimKiemKhoa.TabIndex = 6;
            this.gbTimKiemKhoa.TabStop = false;
            this.gbTimKiemKhoa.Text = "Tìm Kiếm Khoa";
            // 
            // btnTimKiemKhoa
            // 
            this.btnTimKiemKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemKhoa.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemKhoa.Location = new System.Drawing.Point(356, 26);
            this.btnTimKiemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            this.btnTimKiemKhoa.Size = new System.Drawing.Size(108, 32);
            this.btnTimKiemKhoa.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnTimKiemKhoa, "Tìm Kiếm");
            this.btnTimKiemKhoa.UseVisualStyleBackColor = false;
            this.btnTimKiemKhoa.Click += new System.EventHandler(this.btnTimKiemKhoa_Click);
            // 
            // txtTimKiemKhoa
            // 
            this.txtTimKiemKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemKhoa.Location = new System.Drawing.Point(46, 38);
            this.txtTimKiemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemKhoa.Name = "txtTimKiemKhoa";
            this.txtTimKiemKhoa.Size = new System.Drawing.Size(219, 27);
            this.txtTimKiemKhoa.TabIndex = 6;
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaKhoa.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnXoaKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaKhoa.Location = new System.Drawing.Point(462, 113);
            this.btnXoaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(108, 32);
            this.btnXoaKhoa.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnXoaKhoa, "Xóa");
            this.btnXoaKhoa.UseVisualStyleBackColor = false;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaKhoa.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaKhoa.Location = new System.Drawing.Point(462, 64);
            this.btnSuaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(108, 32);
            this.btnSuaKhoa.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSuaKhoa, "Cập Nhật");
            this.btnSuaKhoa.UseVisualStyleBackColor = false;
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnThemKhoa.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemKhoa.Location = new System.Drawing.Point(462, 14);
            this.btnThemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(108, 32);
            this.btnThemKhoa.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnThemKhoa, "Thêm Mới");
            this.btnThemKhoa.UseVisualStyleBackColor = false;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(138, 27);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(182, 27);
            this.txtTenKhoa.TabIndex = 1;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(18, 30);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(82, 20);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Tên Khoa :";
            // 
            // dgvQlKhoa
            // 
            this.dgvQlKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvQlKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQlKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacultyID,
            this.PositionName,
            this.Description});
            this.dgvQlKhoa.Location = new System.Drawing.Point(0, 201);
            this.dgvQlKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQlKhoa.Name = "dgvQlKhoa";
            this.dgvQlKhoa.RowHeadersWidth = 62;
            this.dgvQlKhoa.RowTemplate.Height = 33;
            this.dgvQlKhoa.Size = new System.Drawing.Size(446, 181);
            this.dgvQlKhoa.TabIndex = 2;
            this.dgvQlKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQlKhoa_CellClick);
            // 
            // FacultyID
            // 
            this.FacultyID.DataPropertyName = "Id";
            this.FacultyID.HeaderText = "Mã Khoa";
            this.FacultyID.MinimumWidth = 8;
            this.FacultyID.Name = "FacultyID";
            this.FacultyID.Visible = false;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "Name";
            this.PositionName.HeaderText = "Tên Khoa";
            this.PositionName.MinimumWidth = 8;
            this.PositionName.Name = "PositionName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Mô Tả";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            // 
            // frmQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 399);
            this.Controls.Add(this.dgvQlKhoa);
            this.Controls.Add(this.gbTTKhoa);
            this.Controls.Add(this.lblQlKhoa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyKhoa";
            this.Text = "QuanLyKhoa";
            this.Load += new System.EventHandler(this.frmQuanLyKhoa_Load);
            this.gbTTKhoa.ResumeLayout(false);
            this.gbTTKhoa.PerformLayout();
            this.gbTimKiemKhoa.ResumeLayout(false);
            this.gbTimKiemKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQlKhoa;
        private System.Windows.Forms.GroupBox gbTTKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.GroupBox gbTimKiemKhoa;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.TextBox txtTimKiemKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.DataGridView dgvQlKhoa;
        private System.Windows.Forms.RichTextBox rtbKhoa;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
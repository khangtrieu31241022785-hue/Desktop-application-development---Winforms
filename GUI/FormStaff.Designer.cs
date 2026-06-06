namespace GUI
{
    partial class FormStaff
    {
        private System.ComponentModel.IContainer components = null;

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
            pnl_topBar = new System.Windows.Forms.Panel();
            btn_staffRefresh = new System.Windows.Forms.Button();
            btn_staffResetPass = new System.Windows.Forms.Button();
            btn_staffDisable = new System.Windows.Forms.Button();
            btn_staffEdit = new System.Windows.Forms.Button();
            btn_staffAdd = new System.Windows.Forms.Button();
            pnl_left = new System.Windows.Forms.Panel();
            dgv_staffList = new System.Windows.Forms.DataGridView();
            pnl_Right = new System.Windows.Forms.Panel();
            btn_staffCancel = new System.Windows.Forms.Button();
            btn_staffSave = new System.Windows.Forms.Button();
            cbb_role = new System.Windows.Forms.ComboBox();
            lbl_Role = new System.Windows.Forms.Label();
            txt_phone = new System.Windows.Forms.TextBox();
            lbl_Phone = new System.Windows.Forms.Label();
            txt_password = new System.Windows.Forms.TextBox();
            lbl_Password = new System.Windows.Forms.Label();
            txt_username = new System.Windows.Forms.TextBox();
            lbl_Username = new System.Windows.Forms.Label();
            txt_fullName = new System.Windows.Forms.TextBox();
            lbl_FullName = new System.Windows.Forms.Label();
            lbl_SectionTitle = new System.Windows.Forms.Label();
            pnl_topBar.SuspendLayout();
            pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_staffList).BeginInit();
            pnl_Right.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_topBar
            // 
            pnl_topBar.Controls.Add(btn_staffRefresh);
            pnl_topBar.Controls.Add(btn_staffResetPass);
            pnl_topBar.Controls.Add(btn_staffDisable);
            pnl_topBar.Controls.Add(btn_staffEdit);
            pnl_topBar.Controls.Add(btn_staffAdd);
            pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_topBar.Location = new System.Drawing.Point(0, 0);
            pnl_topBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_topBar.Name = "pnl_topBar";
            pnl_topBar.Size = new System.Drawing.Size(2091, 154);
            pnl_topBar.TabIndex = 0;
            // 
            // btn_staffRefresh
            // 
            btn_staffRefresh.Location = new System.Drawing.Point(1148, 38);
            btn_staffRefresh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_staffRefresh.Name = "btn_staffRefresh";
            btn_staffRefresh.Size = new System.Drawing.Size(212, 77);
            btn_staffRefresh.TabIndex = 4;
            btn_staffRefresh.Text = "Làm mới";
            btn_staffRefresh.UseVisualStyleBackColor = true;
            btn_staffRefresh.Click += btn_StaffRefresh_Click;
            // 
            // btn_staffResetPass
            // 
            btn_staffResetPass.Location = new System.Drawing.Point(850, 38);
            btn_staffResetPass.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_staffResetPass.Name = "btn_staffResetPass";
            btn_staffResetPass.Size = new System.Drawing.Size(255, 77);
            btn_staffResetPass.TabIndex = 3;
            btn_staffResetPass.Text = "Đổi mật khẩu";
            btn_staffResetPass.UseVisualStyleBackColor = true;
            btn_staffResetPass.Click += btn_StaffResetPass_Click;
            // 
            // btn_staffDisable
            // 
            btn_staffDisable.Location = new System.Drawing.Point(552, 38);
            btn_staffDisable.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_staffDisable.Name = "btn_staffDisable";
            btn_staffDisable.Size = new System.Drawing.Size(255, 77);
            btn_staffDisable.TabIndex = 2;
            btn_staffDisable.Text = "Vô hiệu hóa";
            btn_staffDisable.UseVisualStyleBackColor = true;
            btn_staffDisable.Click += btn_StaffDisable_Click;
            // 
            // btn_staffEdit
            // 
            btn_staffEdit.Location = new System.Drawing.Point(298, 38);
            btn_staffEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_staffEdit.Name = "btn_staffEdit";
            btn_staffEdit.Size = new System.Drawing.Size(212, 77);
            btn_staffEdit.TabIndex = 1;
            btn_staffEdit.Text = "Sửa";
            btn_staffEdit.UseVisualStyleBackColor = true;
            btn_staffEdit.Click += btn_StaffEdit_Click;
            // 
            // btn_staffAdd
            // 
            btn_staffAdd.Location = new System.Drawing.Point(42, 38);
            btn_staffAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_staffAdd.Name = "btn_staffAdd";
            btn_staffAdd.Size = new System.Drawing.Size(212, 77);
            btn_staffAdd.TabIndex = 0;
            btn_staffAdd.Text = "Thêm NV";
            btn_staffAdd.UseVisualStyleBackColor = true;
            btn_staffAdd.Click += btn_StaffAdd_Click;
            // 
            // pnl_left
            // 
            pnl_left.Controls.Add(dgv_staffList);
            pnl_left.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_left.Location = new System.Drawing.Point(0, 154);
            pnl_left.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_left.Name = "pnl_left";
            pnl_left.Padding = new System.Windows.Forms.Padding(21, 26, 21, 26);
            pnl_left.Size = new System.Drawing.Size(1456, 1284);
            pnl_left.TabIndex = 1;
            // 
            // dgv_staffList
            // 
            dgv_staffList.AllowUserToAddRows = false;
            dgv_staffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_staffList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_staffList.Location = new System.Drawing.Point(21, 26);
            dgv_staffList.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_staffList.Name = "dgv_staffList";
            dgv_staffList.ReadOnly = true;
            dgv_staffList.RowHeadersWidth = 102;
            dgv_staffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_staffList.Size = new System.Drawing.Size(1414, 1232);
            dgv_staffList.TabIndex = 0;
            dgv_staffList.CellClick += dgv_StaffList_CellClick;
            dgv_staffList.CellFormatting += dgv_StaffList_CellFormatting;
            // 
            // pnl_Right
            // 
            pnl_Right.BackColor = System.Drawing.Color.White;
            pnl_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_Right.Controls.Add(btn_staffCancel);
            pnl_Right.Controls.Add(btn_staffSave);
            pnl_Right.Controls.Add(cbb_role);
            pnl_Right.Controls.Add(lbl_Role);
            pnl_Right.Controls.Add(txt_phone);
            pnl_Right.Controls.Add(lbl_Phone);
            pnl_Right.Controls.Add(txt_password);
            pnl_Right.Controls.Add(lbl_Password);
            pnl_Right.Controls.Add(txt_username);
            pnl_Right.Controls.Add(lbl_Username);
            pnl_Right.Controls.Add(txt_fullName);
            pnl_Right.Controls.Add(lbl_FullName);
            pnl_Right.Controls.Add(lbl_SectionTitle);
            pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            pnl_Right.Location = new System.Drawing.Point(1456, 154);
            pnl_Right.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_Right.Name = "pnl_Right";
            pnl_Right.Size = new System.Drawing.Size(635, 1284);
            pnl_Right.TabIndex = 2;
            // 
            // btn_staffCancel
            // 
            btn_staffCancel.Location = new System.Drawing.Point(329, 1051);
            btn_staffCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_staffCancel.Name = "btn_staffCancel";
            btn_staffCancel.Size = new System.Drawing.Size(212, 90);
            btn_staffCancel.TabIndex = 12;
            btn_staffCancel.Text = "Hủy";
            btn_staffCancel.UseVisualStyleBackColor = true;
            btn_staffCancel.Click += btn_StaffCancel_Click;
            // 
            // btn_staffSave
            // 
            btn_staffSave.Location = new System.Drawing.Point(85, 1051);
            btn_staffSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_staffSave.Name = "btn_staffSave";
            btn_staffSave.Size = new System.Drawing.Size(212, 90);
            btn_staffSave.TabIndex = 11;
            btn_staffSave.Text = "Lưu";
            btn_staffSave.UseVisualStyleBackColor = true;
            btn_staffSave.Click += btn_StaffSave_Click;
            // 
            // cbb_role
            // 
            cbb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_role.FormattingEnabled = true;
            cbb_role.Items.AddRange(new object[] { "Admin", "Quản lý", "Thu ngân", "Kho", "Kỹ thuật" });
            cbb_role.Location = new System.Drawing.Point(42, 897);
            cbb_role.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new System.Drawing.Size(537, 49);
            cbb_role.TabIndex = 10;
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Location = new System.Drawing.Point(36, 846);
            lbl_Role.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new System.Drawing.Size(110, 41);
            lbl_Role.TabIndex = 9;
            lbl_Role.Text = "Vai trò:";
            // 
            // txt_phone
            // 
            txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_phone.Location = new System.Drawing.Point(42, 718);
            txt_phone.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new System.Drawing.Size(537, 46);
            txt_phone.TabIndex = 8;
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Location = new System.Drawing.Point(36, 666);
            lbl_Phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new System.Drawing.Size(200, 41);
            lbl_Phone.TabIndex = 7;
            lbl_Phone.Text = "Số điện thoại:";
            // 
            // txt_password
            // 
            txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_password.Location = new System.Drawing.Point(42, 538);
            txt_password.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_password.Name = "txt_password";
            txt_password.Size = new System.Drawing.Size(537, 46);
            txt_password.TabIndex = 6;
            txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new System.Drawing.Point(36, 487);
            lbl_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new System.Drawing.Size(149, 41);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_username.Location = new System.Drawing.Point(42, 359);
            txt_username.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_username.Name = "txt_username";
            txt_username.Size = new System.Drawing.Size(537, 46);
            txt_username.TabIndex = 4;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new System.Drawing.Point(36, 308);
            lbl_Username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new System.Drawing.Size(171, 41);
            lbl_Username.TabIndex = 3;
            lbl_Username.Text = "Tài khoản *:";
            // 
            // txt_fullName
            // 
            txt_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_fullName.Location = new System.Drawing.Point(42, 179);
            txt_fullName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new System.Drawing.Size(537, 46);
            txt_fullName.TabIndex = 2;
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Location = new System.Drawing.Point(36, 128);
            lbl_FullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new System.Drawing.Size(136, 41);
            lbl_FullName.TabIndex = 1;
            lbl_FullName.Text = "Họ tên *:";
            // 
            // lbl_SectionTitle
            // 
            lbl_SectionTitle.AutoSize = true;
            lbl_SectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbl_SectionTitle.Location = new System.Drawing.Point(34, 38);
            lbl_SectionTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_SectionTitle.Name = "lbl_SectionTitle";
            lbl_SectionTitle.Size = new System.Drawing.Size(335, 39);
            lbl_SectionTitle.TabIndex = 0;
            lbl_SectionTitle.Text = "Thông tin nhân viên";
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2091, 1438);
            Controls.Add(pnl_left);
            Controls.Add(pnl_Right);
            Controls.Add(pnl_topBar);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Text = "FormStaff - Quản lý nhân viên";
            Load += FormStaff_Load;
            pnl_topBar.ResumeLayout(false);
            pnl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_staffList).EndInit();
            pnl_Right.ResumeLayout(false);
            pnl_Right.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Button btn_staffAdd;
        private System.Windows.Forms.Button btn_staffEdit;
        private System.Windows.Forms.Button btn_staffDisable;
        private System.Windows.Forms.Button btn_staffResetPass;
        private System.Windows.Forms.Button btn_staffRefresh;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.DataGridView dgv_staffList;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Label lbl_SectionTitle;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.Button btn_staffSave;
        private System.Windows.Forms.Button btn_staffCancel;
    }
}
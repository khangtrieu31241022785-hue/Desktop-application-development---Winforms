namespace GUI
{
    partial class FormCategory
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
            btn_categoryRefresh = new System.Windows.Forms.Button();
            btn_categoryDelete = new System.Windows.Forms.Button();
            btn_categoryEdit = new System.Windows.Forms.Button();
            btn_categoryAdd = new System.Windows.Forms.Button();
            pnl_Right = new System.Windows.Forms.Panel();
            btn_categoryCancel = new System.Windows.Forms.Button();
            btn_categorySave = new System.Windows.Forms.Button();
            cbb_categoryStatus = new System.Windows.Forms.ComboBox();
            lbl_CategoryStatus = new System.Windows.Forms.Label();
            txt_categoryDesc = new System.Windows.Forms.TextBox();
            lbl_CategoryDesc = new System.Windows.Forms.Label();
            txt_categoryName = new System.Windows.Forms.TextBox();
            lbl_CategoryName = new System.Windows.Forms.Label();
            lbl_SectionTitle = new System.Windows.Forms.Label();
            pnl_Left = new System.Windows.Forms.Panel();
            dgv_categoryList = new System.Windows.Forms.DataGridView();
            pnl_search = new System.Windows.Forms.Panel();
            txt_categorySearch = new System.Windows.Forms.TextBox();
            pnl_status = new System.Windows.Forms.Panel();
            lbl_statusSummary = new System.Windows.Forms.Label();
            pnl_topBar.SuspendLayout();
            pnl_Right.SuspendLayout();
            pnl_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoryList).BeginInit();
            pnl_search.SuspendLayout();
            pnl_status.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_topBar
            // 
            pnl_topBar.Controls.Add(btn_categoryRefresh);
            pnl_topBar.Controls.Add(btn_categoryDelete);
            pnl_topBar.Controls.Add(btn_categoryEdit);
            pnl_topBar.Controls.Add(btn_categoryAdd);
            pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_topBar.Location = new System.Drawing.Point(0, 0);
            pnl_topBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_topBar.Name = "pnl_topBar";
            pnl_topBar.Size = new System.Drawing.Size(2006, 154);
            pnl_topBar.TabIndex = 0;
            // 
            // btn_categoryRefresh
            // 
            btn_categoryRefresh.Location = new System.Drawing.Point(808, 38);
            btn_categoryRefresh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryRefresh.Name = "btn_categoryRefresh";
            btn_categoryRefresh.Size = new System.Drawing.Size(212, 77);
            btn_categoryRefresh.TabIndex = 3;
            btn_categoryRefresh.Text = "Làm mới";
            btn_categoryRefresh.UseVisualStyleBackColor = true;
            btn_categoryRefresh.Click += btn_CategoryRefresh_Click;
            // 
            // btn_categoryDelete
            // 
            btn_categoryDelete.Location = new System.Drawing.Point(552, 38);
            btn_categoryDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryDelete.Name = "btn_categoryDelete";
            btn_categoryDelete.Size = new System.Drawing.Size(212, 77);
            btn_categoryDelete.TabIndex = 2;
            btn_categoryDelete.Text = "Xóa";
            btn_categoryDelete.UseVisualStyleBackColor = true;
            btn_categoryDelete.Click += btn_CategoryDelete_Click;
            // 
            // btn_categoryEdit
            // 
            btn_categoryEdit.Location = new System.Drawing.Point(298, 38);
            btn_categoryEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryEdit.Name = "btn_categoryEdit";
            btn_categoryEdit.Size = new System.Drawing.Size(212, 77);
            btn_categoryEdit.TabIndex = 1;
            btn_categoryEdit.Text = "Sửa";
            btn_categoryEdit.UseVisualStyleBackColor = true;
            btn_categoryEdit.Click += btn_CategoryEdit_Click;
            // 
            // btn_categoryAdd
            // 
            btn_categoryAdd.Location = new System.Drawing.Point(42, 38);
            btn_categoryAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryAdd.Name = "btn_categoryAdd";
            btn_categoryAdd.Size = new System.Drawing.Size(212, 77);
            btn_categoryAdd.TabIndex = 0;
            btn_categoryAdd.Text = "Thêm";
            btn_categoryAdd.UseVisualStyleBackColor = true;
            btn_categoryAdd.Click += btn_CategoryAdd_Click;
            // 
            // pnl_Right
            // 
            pnl_Right.BackColor = System.Drawing.Color.White;
            pnl_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_Right.Controls.Add(btn_categoryCancel);
            pnl_Right.Controls.Add(btn_categorySave);
            pnl_Right.Controls.Add(cbb_categoryStatus);
            pnl_Right.Controls.Add(lbl_CategoryStatus);
            pnl_Right.Controls.Add(txt_categoryDesc);
            pnl_Right.Controls.Add(lbl_CategoryDesc);
            pnl_Right.Controls.Add(txt_categoryName);
            pnl_Right.Controls.Add(lbl_CategoryName);
            pnl_Right.Controls.Add(lbl_SectionTitle);
            pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            pnl_Right.Location = new System.Drawing.Point(1328, 154);
            pnl_Right.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_Right.Name = "pnl_Right";
            pnl_Right.Size = new System.Drawing.Size(678, 1207);
            pnl_Right.TabIndex = 2;
            // 
            // btn_categoryCancel
            // 
            btn_categoryCancel.Location = new System.Drawing.Point(351, 999);
            btn_categoryCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryCancel.Name = "btn_categoryCancel";
            btn_categoryCancel.Size = new System.Drawing.Size(212, 90);
            btn_categoryCancel.TabIndex = 8;
            btn_categoryCancel.Text = "Hủy";
            btn_categoryCancel.UseVisualStyleBackColor = true;
            btn_categoryCancel.Click += btn_CategoryCancel_Click;
            // 
            // btn_categorySave
            // 
            btn_categorySave.Location = new System.Drawing.Point(106, 999);
            btn_categorySave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categorySave.Name = "btn_categorySave";
            btn_categorySave.Size = new System.Drawing.Size(212, 90);
            btn_categorySave.TabIndex = 7;
            btn_categorySave.Text = "Lưu";
            btn_categorySave.UseVisualStyleBackColor = true;
            btn_categorySave.Click += btn_CategorySave_Click;
            // 
            // cbb_categoryStatus
            // 
            cbb_categoryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_categoryStatus.FormattingEnabled = true;
            cbb_categoryStatus.Items.AddRange(new object[] { "Hoạt động", "Ngừng" });
            cbb_categoryStatus.Location = new System.Drawing.Point(42, 820);
            cbb_categoryStatus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            cbb_categoryStatus.Name = "cbb_categoryStatus";
            cbb_categoryStatus.Size = new System.Drawing.Size(580, 49);
            cbb_categoryStatus.TabIndex = 6;
            // 
            // lbl_CategoryStatus
            // 
            lbl_CategoryStatus.AutoSize = true;
            lbl_CategoryStatus.Location = new System.Drawing.Point(36, 769);
            lbl_CategoryStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_CategoryStatus.Name = "lbl_CategoryStatus";
            lbl_CategoryStatus.Size = new System.Drawing.Size(155, 41);
            lbl_CategoryStatus.TabIndex = 5;
            lbl_CategoryStatus.Text = "Trạng thái:";
            // 
            // txt_categoryDesc
            // 
            txt_categoryDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_categoryDesc.Location = new System.Drawing.Point(42, 384);
            txt_categoryDesc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_categoryDesc.Multiline = true;
            txt_categoryDesc.Name = "txt_categoryDesc";
            txt_categoryDesc.Size = new System.Drawing.Size(580, 301);
            txt_categoryDesc.TabIndex = 4;
            // 
            // lbl_CategoryDesc
            // 
            lbl_CategoryDesc.AutoSize = true;
            lbl_CategoryDesc.Location = new System.Drawing.Point(36, 333);
            lbl_CategoryDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_CategoryDesc.Name = "lbl_CategoryDesc";
            lbl_CategoryDesc.Size = new System.Drawing.Size(103, 41);
            lbl_CategoryDesc.TabIndex = 3;
            lbl_CategoryDesc.Text = "Mô tả:";
            // 
            // txt_categoryName
            // 
            txt_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_categoryName.Location = new System.Drawing.Point(42, 205);
            txt_categoryName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_categoryName.Name = "txt_categoryName";
            txt_categoryName.Size = new System.Drawing.Size(580, 46);
            txt_categoryName.TabIndex = 2;
            // 
            // lbl_CategoryName
            // 
            lbl_CategoryName.AutoSize = true;
            lbl_CategoryName.Location = new System.Drawing.Point(36, 154);
            lbl_CategoryName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_CategoryName.Name = "lbl_CategoryName";
            lbl_CategoryName.Size = new System.Drawing.Size(232, 41);
            lbl_CategoryName.TabIndex = 1;
            lbl_CategoryName.Text = "Tên danh mục *:";
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
            lbl_SectionTitle.Text = "Thông tin danh mục";
            // 
            // pnl_Left
            // 
            pnl_Left.Controls.Add(dgv_categoryList);
            pnl_Left.Controls.Add(pnl_search);
            pnl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_Left.Location = new System.Drawing.Point(0, 154);
            pnl_Left.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_Left.Name = "pnl_Left";
            pnl_Left.Padding = new System.Windows.Forms.Padding(21, 0, 21, 26);
            pnl_Left.Size = new System.Drawing.Size(1328, 1207);
            pnl_Left.TabIndex = 1;
            // 
            // dgv_categoryList
            // 
            dgv_categoryList.AllowUserToAddRows = false;
            dgv_categoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_categoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_categoryList.Location = new System.Drawing.Point(21, 128);
            dgv_categoryList.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_categoryList.Name = "dgv_categoryList";
            dgv_categoryList.ReadOnly = true;
            dgv_categoryList.RowHeadersWidth = 102;
            dgv_categoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_categoryList.Size = new System.Drawing.Size(1286, 1053);
            dgv_categoryList.TabIndex = 1;
            dgv_categoryList.CellClick += dgv_CategoryList_CellClick;
            dgv_categoryList.CellFormatting += dgv_CategoryList_CellFormatting;
            // 
            // pnl_search
            // 
            pnl_search.Controls.Add(txt_categorySearch);
            pnl_search.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_search.Location = new System.Drawing.Point(21, 0);
            pnl_search.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_search.Name = "pnl_search";
            pnl_search.Size = new System.Drawing.Size(1286, 128);
            pnl_search.TabIndex = 0;
            // 
            // txt_categorySearch
            // 
            txt_categorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_categorySearch.Location = new System.Drawing.Point(0, 26);
            txt_categorySearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_categorySearch.Name = "txt_categorySearch";
            txt_categorySearch.Size = new System.Drawing.Size(633, 46);
            txt_categorySearch.TabIndex = 0;
            txt_categorySearch.Text = "Tìm danh mục...";
            txt_categorySearch.TextChanged += txt_CategorySearch_TextChanged;
            txt_categorySearch.Enter += txt_CategorySearch_Enter;
            txt_categorySearch.Leave += txt_CategorySearch_Leave;
            // 
            // pnl_status
            // 
            pnl_status.Controls.Add(lbl_statusSummary);
            pnl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_status.Location = new System.Drawing.Point(0, 1361);
            pnl_status.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_status.Name = "pnl_status";
            pnl_status.Size = new System.Drawing.Size(2006, 77);
            pnl_status.TabIndex = 3;
            // 
            // lbl_statusSummary
            // 
            lbl_statusSummary.AutoSize = true;
            lbl_statusSummary.Location = new System.Drawing.Point(26, 18);
            lbl_statusSummary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_statusSummary.Name = "lbl_statusSummary";
            lbl_statusSummary.Size = new System.Drawing.Size(528, 41);
            lbl_statusSummary.TabIndex = 0;
            lbl_statusSummary.Text = "Tổng: 0 danh mục | Đang chọn: Không";
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2006, 1438);
            Controls.Add(pnl_Left);
            Controls.Add(pnl_Right);
            Controls.Add(pnl_topBar);
            Controls.Add(pnl_status);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Text = "Quản lý danh mục sản phẩm";
            Load += FormCategory_Load;
            pnl_topBar.ResumeLayout(false);
            pnl_Right.ResumeLayout(false);
            pnl_Right.PerformLayout();
            pnl_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_categoryList).EndInit();
            pnl_search.ResumeLayout(false);
            pnl_search.PerformLayout();
            pnl_status.ResumeLayout(false);
            pnl_status.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Button btn_categoryAdd;
        private System.Windows.Forms.Button btn_categoryEdit;
        private System.Windows.Forms.Button btn_categoryDelete;
        private System.Windows.Forms.Button btn_categoryRefresh;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Label lbl_SectionTitle;
        private System.Windows.Forms.Label lbl_CategoryName;
        private System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.Label lbl_CategoryDesc;
        private System.Windows.Forms.TextBox txt_categoryDesc;
        private System.Windows.Forms.Label lbl_CategoryStatus;
        private System.Windows.Forms.ComboBox cbb_categoryStatus;
        private System.Windows.Forms.Button btn_categorySave;
        private System.Windows.Forms.Button btn_categoryCancel;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.DataGridView dgv_categoryList;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.TextBox txt_categorySearch;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_statusSummary;
    }
}
using System.ComponentModel;

namespace GUI;

partial class FormPromotion
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        groupBox1 = new System.Windows.Forms.GroupBox();
        btn_Delete = new System.Windows.Forms.Button();
        btn_Update = new System.Windows.Forms.Button();
        btn_Add = new System.Windows.Forms.Button();
        dt_End = new System.Windows.Forms.DateTimePicker();
        dt_Start = new System.Windows.Forms.DateTimePicker();
        num_Discount = new System.Windows.Forms.NumericUpDown();
        txt_PromotionName = new System.Windows.Forms.TextBox();
        txt_PromotionID = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        dgv_Promotion = new System.Windows.Forms.DataGridView();
        col_Promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_PromotionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)num_Discount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgv_Promotion).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btn_Delete);
        groupBox1.Controls.Add(btn_Update);
        groupBox1.Controls.Add(btn_Add);
        groupBox1.Controls.Add(dt_End);
        groupBox1.Controls.Add(dt_Start);
        groupBox1.Controls.Add(num_Discount);
        groupBox1.Controls.Add(txt_PromotionName);
        groupBox1.Controls.Add(txt_PromotionID);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new System.Drawing.Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(1401, 265);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = " ";
        // 
        // btn_Delete
        // 
        btn_Delete.Location = new System.Drawing.Point(713, 172);
        btn_Delete.Name = "btn_Delete";
        btn_Delete.Size = new System.Drawing.Size(94, 29);
        btn_Delete.TabIndex = 12;
        btn_Delete.Text = "Xóa";
        btn_Delete.UseVisualStyleBackColor = true;
        // 
        // btn_Update
        // 
        btn_Update.Location = new System.Drawing.Point(589, 172);
        btn_Update.Name = "btn_Update";
        btn_Update.Size = new System.Drawing.Size(94, 29);
        btn_Update.TabIndex = 11;
        btn_Update.Text = "Sửa";
        btn_Update.UseVisualStyleBackColor = true;
        // 
        // btn_Add
        // 
        btn_Add.Location = new System.Drawing.Point(470, 172);
        btn_Add.Name = "btn_Add";
        btn_Add.Size = new System.Drawing.Size(94, 29);
        btn_Add.TabIndex = 10;
        btn_Add.Text = "Thêm";
        btn_Add.UseVisualStyleBackColor = true;
        // 
        // dt_End
        // 
        dt_End.Location = new System.Drawing.Point(171, 211);
        dt_End.Name = "dt_End";
        dt_End.Size = new System.Drawing.Size(276, 47);
        dt_End.TabIndex = 9;
        // 
        // dt_Start
        // 
        dt_Start.Location = new System.Drawing.Point(148, 160);
        dt_Start.Name = "dt_Start";
        dt_Start.Size = new System.Drawing.Size(276, 47);
        dt_Start.TabIndex = 8;
        // 
        // num_Discount
        // 
        num_Discount.Location = new System.Drawing.Point(136, 122);
        num_Discount.Name = "num_Discount";
        num_Discount.Size = new System.Drawing.Size(214, 47);
        num_Discount.TabIndex = 7;
        // 
        // txt_PromotionName
        // 
        txt_PromotionName.Location = new System.Drawing.Point(171, 81);
        txt_PromotionName.Name = "txt_PromotionName";
        txt_PromotionName.Size = new System.Drawing.Size(336, 47);
        txt_PromotionName.TabIndex = 6;
        // 
        // txt_PromotionID
        // 
        txt_PromotionID.Location = new System.Drawing.Point(185, 32);
        txt_PromotionID.Name = "txt_PromotionID";
        txt_PromotionID.Size = new System.Drawing.Size(125, 47);
        txt_PromotionID.TabIndex = 5;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new System.Drawing.Point(41, 211);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(211, 41);
        label5.TabIndex = 4;
        label5.Text = "Ngày Kết Thúc";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(41, 122);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(112, 41);
        label4.TabIndex = 3;
        label4.Text = "Giảm%";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(41, 160);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(199, 41);
        label3.TabIndex = 2;
        label3.Text = "Ngày Bắt Đầu";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(41, 88);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(251, 41);
        label2.TabIndex = 1;
        label2.Text = "Tên Chương Trình";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(41, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(224, 41);
        label1.TabIndex = 0;
        label1.Text = "Mã Khuyến Mãi";
        // 
        // dgv_Promotion
        // 
        dgv_Promotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Promotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_Promotion, col_PromotionName, col_Discount, col_Start, col_End });
        dgv_Promotion.Location = new System.Drawing.Point(12, 283);
        dgv_Promotion.Name = "dgv_Promotion";
        dgv_Promotion.RowHeadersWidth = 51;
        dgv_Promotion.Size = new System.Drawing.Size(1401, 789);
        dgv_Promotion.TabIndex = 1;
        dgv_Promotion.CellContentClick += dgv_Promotion_CellContentClick;
        // 
        // col_Promotion
        // 
        col_Promotion.HeaderText = "Mã Khuyến Mãi";
        col_Promotion.MinimumWidth = 6;
        col_Promotion.Name = "col_Promotion";
        col_Promotion.Width = 125;
        // 
        // col_PromotionName
        // 
        col_PromotionName.HeaderText = "Tên Chương Trình";
        col_PromotionName.MinimumWidth = 6;
        col_PromotionName.Name = "col_PromotionName";
        col_PromotionName.Width = 125;
        // 
        // col_Discount
        // 
        col_Discount.HeaderText = "Giảm %";
        col_Discount.MinimumWidth = 6;
        col_Discount.Name = "col_Discount";
        col_Discount.Width = 125;
        // 
        // col_Start
        // 
        col_Start.HeaderText = "Ngày Bắt Đầu";
        col_Start.MinimumWidth = 6;
        col_Start.Name = "col_Start";
        col_Start.Width = 125;
        // 
        // col_End
        // 
        col_End.HeaderText = "Ngày Kết Thúc";
        col_End.MinimumWidth = 6;
        col_End.Name = "col_End";
        col_End.Width = 125;
        // 
        // FormPromotion
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1425, 1084);
        Controls.Add(dgv_Promotion);
        Controls.Add(groupBox1);
        Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
        Text = "FormPromotion";
        Load += FormPromotion_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)num_Discount).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgv_Promotion).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgv_Promotion;
    private System.Windows.Forms.GroupBox groupBox1;

    #endregion

    private GroupBox groupBox3;
    private TextBox txt_promotionCode;
    private TextBox txt_description;
    private TextBox txt_discountValue;
    private Button btn_save;
    private Button btn_cancel;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private GroupBox groupBox2;
    private DataGridView dgv_guest;
    private Button btn_createPromotion;
    private Button btn_refresh;
    private Button btn_edit;
    private Button btn_disablePromotion;
    private DateTimePicker dtp_endDate;
    private Label label1;
    private DateTimePicker dtp_startDate;
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private DataGridViewTextBoxColumn col_PromotionCode;
    private DataGridViewTextBoxColumn col_Description;
    private DataGridViewTextBoxColumn col_DiscountPercentage;
    private DataGridViewTextBoxColumn col_DiscountAmount;
    private DataGridViewTextBoxColumn col_StartDate;
    private DataGridViewTextBoxColumn col_EndDate;
    private DataGridViewTextBoxColumn col_Status;
}
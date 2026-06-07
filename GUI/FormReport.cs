using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI;

public partial class FormReport : Form
{
    private List<ReportRecord> _reportList = new List<ReportRecord>
    {
        new ReportRecord { InvoiceCode = "HD012", SaleTime = "09:15", CustomerName = "Nguyễn Văn A", ProductName = "iPhone 15 Pro", Revenue = 28990000, Profit = 4990000, PaymentMethod = "Tiền mặt" },
        new ReportRecord { InvoiceCode = "HD011", SaleTime = "08:45", CustomerName = "Khách lẻ",     ProductName = "AirPods Pro 2", Revenue = 6490000,  Profit = 1990000, PaymentMethod = "CK" },
    };

    public FormReport()
    {
        InitializeComponent();
        LoadReport();
    }

    private void LoadReport()
    {
        UpdateCards();
        LoadTable();
        UpdateFooter();
    }

    private void UpdateCards()
    {
        lbl_doanhThu.Text         = "145,200,000\nDoanh thu (đ)";
        lbl_grossProfit.Text      = "42,300,000\nLợi nhuận gộp (đ)";
        lbl_invoiceNum.Text         = "12\nSố hóa đơn";
        lbl_productSold.Text     = "18\nSản phẩm bán ra";
        lbl_warranty.Text  = "3\nBảo hành phát sinh";

        lbl_doanhThu.ForeColor        = Color.FromArgb(0, 102, 204);
        lbl_grossProfit.ForeColor     = Color.FromArgb(0, 140, 0);
        lbl_warranty.ForeColor = Color.FromArgb(200, 100, 0);

        lbl_doanhThu.TextAlign        = ContentAlignment.MiddleCenter;
        lbl_grossProfit.TextAlign     = ContentAlignment.MiddleCenter;
        lbl_invoiceNum.TextAlign        = ContentAlignment.MiddleCenter;
        lbl_productSold.TextAlign    = ContentAlignment.MiddleCenter;
        lbl_warranty.TextAlign = ContentAlignment.MiddleCenter;

        lbl_doanhThu.Font        = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_grossProfit.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_invoiceNum.Font        = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_productSold.Font    = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_warranty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
    }

    private void LoadTable()
    {
        dgv_listInvoices.Rows.Clear();
        dgv_listInvoices.RowHeadersVisible  = false;
        dgv_listInvoices.AllowUserToAddRows = false;
        dgv_listInvoices.ReadOnly           = true;
        dgv_listInvoices.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
        dgv_listInvoices.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);

        foreach (var r in _reportList)
        {
            int i = dgv_listInvoices.Rows.Add(
                r.InvoiceCode, r.SaleTime, r.CustomerName, r.ProductName,
                string.Format("{0:N0}", r.Revenue),
                string.Format("{0:N0}", r.Profit),
                r.PaymentMethod
            );
            var payCell = dgv_listInvoices.Rows[i].Cells["col_thanhToan"];
            if (r.PaymentMethod == "Tiền mặt")
            { payCell.Style.BackColor = Color.FromArgb(0, 140, 0);   payCell.Style.ForeColor = Color.White; }
            else
            { payCell.Style.BackColor = Color.FromArgb(0, 102, 204); payCell.Style.ForeColor = Color.White; }
        }
    }

    private void UpdateFooter()
    {
        lbl_footerLeft.Text  = "Báo cáo ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
        lbl_footerRight.Text = "Tỉ lệ lợi nhuận: 29.1%";
    }

    private void btn_xemBaocao_Click(object sender, EventArgs e)
    {
        LoadReport();
    }

    private void btn_xuatExcel_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Tính năng xuất Excel đang phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void label1_Click(object sender, EventArgs e) { }

    private void pnl_Top_Paint(object sender, PaintEventArgs e) { }
}

public class ReportRecord
{
    public string  InvoiceCode   { get; set; }
    public string  SaleTime      { get; set; }
    public string  CustomerName  { get; set; }
    public string  ProductName   { get; set; }
    public decimal Revenue       { get; set; }
    public decimal Profit        { get; set; }
    public string  PaymentMethod { get; set; }
}
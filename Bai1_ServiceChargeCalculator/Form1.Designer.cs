namespace Bai1_ServiceChargeCalculator;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTieuDe = new Label();
        lblDonGia = new Label();
        txtDonGia = new TextBox();
        lblSoLuong = new Label();
        txtSoLuong = new TextBox();
        lblGiamGia = new Label();
        txtGiamGia = new TextBox();
        pnlKetQua = new Panel();
        lblTongTien = new Label();
        lblTongTienCaption = new Label();
        btnTinhTien = new Button();
        btnLamMoi = new Button();
        lblGoiY = new Label();
        pnlKetQua.SuspendLayout();
        SuspendLayout();
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTieuDe.Location = new Point(49, 28);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(414, 37);
        lblTieuDe.TabIndex = 10;
        lblTieuDe.Text = "MÁY TÍNH CƯỚC DỊCH VỤ";
        // 
        // lblDonGia
        // 
        lblDonGia.AutoSize = true;
        lblDonGia.Font = new Font("Segoe UI", 10F);
        lblDonGia.Location = new Point(52, 101);
        lblDonGia.Name = "lblDonGia";
        lblDonGia.Size = new Size(140, 23);
        lblDonGia.TabIndex = 11;
        lblDonGia.Text = "Đơn giá dịch vụ:";
        // 
        // txtDonGia
        // 
        txtDonGia.Font = new Font("Segoe UI", 10F);
        txtDonGia.Location = new Point(224, 97);
        txtDonGia.Name = "txtDonGia";
        txtDonGia.PlaceholderText = "Ví dụ: 200000";
        txtDonGia.Size = new Size(239, 30);
        txtDonGia.TabIndex = 0;
        txtDonGia.TextAlign = HorizontalAlignment.Right;
        // 
        // lblSoLuong
        // 
        lblSoLuong.AutoSize = true;
        lblSoLuong.Font = new Font("Segoe UI", 10F);
        lblSoLuong.Location = new Point(52, 153);
        lblSoLuong.Name = "lblSoLuong";
        lblSoLuong.Size = new Size(133, 23);
        lblSoLuong.TabIndex = 12;
        lblSoLuong.Text = "Số lượng khách:";
        // 
        // txtSoLuong
        // 
        txtSoLuong.Font = new Font("Segoe UI", 10F);
        txtSoLuong.Location = new Point(224, 149);
        txtSoLuong.Name = "txtSoLuong";
        txtSoLuong.PlaceholderText = "Ví dụ: 3";
        txtSoLuong.Size = new Size(239, 30);
        txtSoLuong.TabIndex = 1;
        txtSoLuong.TextAlign = HorizontalAlignment.Right;
        // 
        // lblGiamGia
        // 
        lblGiamGia.AutoSize = true;
        lblGiamGia.Font = new Font("Segoe UI", 10F);
        lblGiamGia.Location = new Point(52, 205);
        lblGiamGia.Name = "lblGiamGia";
        lblGiamGia.Size = new Size(116, 23);
        lblGiamGia.TabIndex = 13;
        lblGiamGia.Text = "Giảm giá (%):";
        // 
        // txtGiamGia
        // 
        txtGiamGia.Font = new Font("Segoe UI", 10F);
        txtGiamGia.Location = new Point(224, 201);
        txtGiamGia.Name = "txtGiamGia";
        txtGiamGia.PlaceholderText = "Ví dụ: 10";
        txtGiamGia.Size = new Size(239, 30);
        txtGiamGia.TabIndex = 2;
        txtGiamGia.TextAlign = HorizontalAlignment.Right;
        // 
        // pnlKetQua
        // 
        pnlKetQua.BorderStyle = BorderStyle.FixedSingle;
        pnlKetQua.Controls.Add(lblTongTien);
        pnlKetQua.Controls.Add(lblTongTienCaption);
        pnlKetQua.Location = new Point(52, 262);
        pnlKetQua.Name = "pnlKetQua";
        pnlKetQua.Size = new Size(411, 91);
        pnlKetQua.TabIndex = 14;
        // 
        // lblTongTien
        // 
        lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTongTien.Location = new Point(149, 26);
        lblTongTien.Name = "lblTongTien";
        lblTongTien.Size = new Size(241, 32);
        lblTongTien.TabIndex = 1;
        lblTongTien.Text = "0 VNĐ";
        lblTongTien.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblTongTienCaption
        // 
        lblTongTienCaption.AutoSize = true;
        lblTongTienCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTongTienCaption.Location = new Point(16, 31);
        lblTongTienCaption.Name = "lblTongTienCaption";
        lblTongTienCaption.Size = new Size(95, 23);
        lblTongTienCaption.TabIndex = 0;
        lblTongTienCaption.Text = "Tổng tiền:";
        // 
        // btnTinhTien
        // 
        btnTinhTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnTinhTien.Location = new Point(120, 383);
        btnTinhTien.Name = "btnTinhTien";
        btnTinhTien.Size = new Size(130, 43);
        btnTinhTien.TabIndex = 3;
        btnTinhTien.Text = "Tính tiền";
        btnTinhTien.UseVisualStyleBackColor = true;
        btnTinhTien.Click += btnTinhTien_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Font = new Font("Segoe UI", 10F);
        btnLamMoi.Location = new Point(270, 383);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(130, 43);
        btnLamMoi.TabIndex = 4;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // lblGoiY
        // 
        lblGoiY.AutoSize = true;
        lblGoiY.ForeColor = SystemColors.GrayText;
        lblGoiY.Location = new Point(52, 446);
        lblGoiY.Name = "lblGoiY";
        lblGoiY.Size = new Size(404, 20);
        lblGoiY.TabIndex = 15;
        lblGoiY.Text = "Công thức: (Đơn giá × Số lượng) × (100 - % giảm) / 100";
        // 
        // Form1
        // 
        AcceptButton = btnTinhTien;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(520, 495);
        Controls.Add(lblGoiY);
        Controls.Add(btnLamMoi);
        Controls.Add(btnTinhTien);
        Controls.Add(pnlKetQua);
        Controls.Add(txtGiamGia);
        Controls.Add(lblGiamGia);
        Controls.Add(txtSoLuong);
        Controls.Add(lblSoLuong);
        Controls.Add(txtDonGia);
        Controls.Add(lblDonGia);
        Controls.Add(lblTieuDe);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 1 - Service Charge Calculator";
        pnlKetQua.ResumeLayout(false);
        pnlKetQua.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTieuDe;
    private Label lblDonGia;
    private TextBox txtDonGia;
    private Label lblSoLuong;
    private TextBox txtSoLuong;
    private Label lblGiamGia;
    private TextBox txtGiamGia;
    private Panel pnlKetQua;
    private Label lblTongTienCaption;
    private Label lblTongTien;
    private Button btnTinhTien;
    private Button btnLamMoi;
    private Label lblGoiY;
}

using System.Globalization;

namespace Bai1_ServiceChargeCalculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnTinhTien_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
        {
            HienThiLoi("Đơn giá dịch vụ phải là số.", txtDonGia);
            return;
        }

        if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong))
        {
            HienThiLoi("Số lượng khách phải là số nguyên.", txtSoLuong);
            return;
        }

        if (!decimal.TryParse(txtGiamGia.Text.Trim(), out decimal giamGia))
        {
            HienThiLoi("Phần trăm giảm giá phải là số.", txtGiamGia);
            return;
        }

        if (donGia <= 0)
        {
            HienThiLoi("Đơn giá dịch vụ phải lớn hơn 0.", txtDonGia);
            return;
        }

        if (soLuong <= 0)
        {
            HienThiLoi("Số lượng khách phải lớn hơn 0.", txtSoLuong);
            return;
        }

        if (giamGia < 0 || giamGia > 100)
        {
            HienThiLoi("Giảm giá phải nằm trong khoảng từ 0 đến 100%.", txtGiamGia);
            return;
        }

        decimal tongTruocGiam = donGia * soLuong;
        decimal tongThanhToan = tongTruocGiam * (100 - giamGia) / 100;

        lblTongTien.Text = tongThanhToan.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtDonGia.Clear();
        txtSoLuong.Clear();
        txtGiamGia.Clear();
        lblTongTien.Text = "0 VNĐ";
        txtDonGia.Focus();
    }

    private static void HienThiLoi(string noiDung, Control control)
    {
        MessageBox.Show(
            noiDung,
            "Dữ liệu không hợp lệ",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);

        control.Focus();

        if (control is TextBox textBox)
            textBox.SelectAll();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DTO;
using BUS;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI.BaoCao
{
    public partial class UC_BaoCaoDoanhThu : UserControl
    {

        BUS_DoanhThuSuaChua bus_DoanhThuSuaChua = new BUS_DoanhThuSuaChua();
        BUS_DoanhThuVatTu bus_DoanhThuVatTu = new BUS_DoanhThuVatTu();
        private static UC_BaoCaoDoanhThu _instance;
        public static UC_BaoCaoDoanhThu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_BaoCaoDoanhThu();
                }
                return _instance;
            }
        }

        public void UC_BaoCaoDoanhThu_Load()
        {
            dtpkFrom.Value = DateTime.Now;
            dtpkTo.Value = DateTime.Now;
        }
        public UC_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            //dtgvTienNhapVatTu.Rows.Clear();
            dtgvTienNhapVatTu.Refresh();

            //dtgvTienPhiSuaChua.Rows.Clear();
            dtgvTienPhiSuaChua.Refresh();

            lbDoanhThu.Text = "";
            lbTongTienNhapVatTu.Text = "";
        }

        private void BtnXemDoanhThu_Click(object sender, EventArgs e)
        {
            if (dtpkFrom.Value != dtpkTo.Value)
            {
                DataTable dt = bus_DoanhThuVatTu.BUS_GetDoanhThuVatTu(dtpkFrom.Value, dtpkTo.Value);

                Exception ex = bus_DoanhThuVatTu.GetException();

                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                dtgvTienNhapVatTu.DataSource = dt;

                dtgvTienNhapVatTu.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
                dtgvTienNhapVatTu.Columns["Tenvattu"].HeaderText = "Tên vật tư";
                //dtgvTienNhapVatTu.Columns["Giathanh"].HeaderText = "Đơn giá";
                dtgvTienNhapVatTu.Columns["Soluongdung"].HeaderText = "Số lượng đã dùng";
                dtgvTienNhapVatTu.Columns["Tienlai"].HeaderText = "Tiền lãi";
                //dtgvTienNhapVatTu.Columns["Ngaynhapkho"].HeaderText = "Ngày nhập kho";
                //dtgvTienNhapVatTu.Columns["Ten"].HeaderText = "Tên nhân viên";

                //dtgvTienNhapVatTu.Columns["Ngaynhapkho"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";

                dtgvTienNhapVatTu.Columns["Tienlai"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                dtgvTienNhapVatTu.Columns["Tienlai"].DefaultCellStyle.Format = "C";



                int TongTienVatTu = 0;
                foreach (DataGridViewRow row in dtgvTienNhapVatTu.Rows)
                {
                    TongTienVatTu += int.Parse(row.Cells["Tienlai"].Value.ToString());
                }
                lbTongTienNhapVatTu.Text = TongTienVatTu.ToString();

                //ẩn cột tên
                //dtgvTienNhapVatTu.Columns["Ten"].Visible = false;

                DataTable dtsc = bus_DoanhThuSuaChua.BUS_GetDoanhThuSuaChua(dtpkFrom.Value, dtpkTo.Value);
                Exception exdt = bus_DoanhThuSuaChua.GetException();
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                dtgvTienPhiSuaChua.DataSource = dtsc;
                dtgvTienPhiSuaChua.Columns["Madonhang"].HeaderText = "Mã đơn hàng";
                dtgvTienPhiSuaChua.Columns["Ngayxuat"].HeaderText = "Ngày xuất";
                dtgvTienPhiSuaChua.Columns["Tiendichvu"].HeaderText = "Tiền dịch vụ";
                //dtgvTienPhiSuaChua.Columns["Ngayxuat"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                int TongTienSuaChua = 0;
                foreach (DataGridViewRow row in dtgvTienPhiSuaChua.Rows)
                {
                    TongTienSuaChua += int.Parse(row.Cells["Tiendichvu"].Value.ToString());
                }
                int TongTien = TongTienVatTu + TongTienSuaChua;
                lbDoanhThu.Text = TongTien.ToString();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải khác nhau!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            //export2Excel(dtgvTonKho, @"D:\", "xuatfileTonKho");
            //Tạo đối tượng lưu tệp tin
            SaveFileDialog fsave = new SaveFileDialog();
            //chỉ ra đuôi
            fsave.Filter = "(Tất cả các tệp) | *.*|(Các tệp excel)|*.xlsx";
            fsave.ShowDialog();
            //xử lý
            if (fsave.FileName != "")
            {
                //tạo excel app
                Excel.Application app = new Excel.Application();
                //tạo 1 workbook
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);

                //tạo sheet
                Excel._Worksheet sheet = null;

                try
                {
                    //đọc dữ liệu từ Listview export ra file Excel có đinh dạng
                    sheet = wb.ActiveSheet;
                    sheet.Name = "Báo cáo doanh thu";
                    sheet.Columns.ColumnWidth = 25;
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dtgvTienNhapVatTu.Columns.Count]].Merge();
                    sheet.Cells[1, 1].value = "DOANH THU TIỀN VẬT TƯ";
                    sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    //sinh tiêu đề vật tư
                    for (int i = 1; i <= dtgvTienNhapVatTu.Columns.Count; i++)
                    {
                        sheet.Cells[2, i] = dtgvTienNhapVatTu.Columns[i - 1].HeaderText;
                    }
                    //sinh du lieu vat tu
                    for (int i = 0; i < dtgvTienNhapVatTu.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgvTienNhapVatTu.Columns.Count; j++)
                        {
                            if (dtgvTienNhapVatTu.Rows[i].Cells[j].Value != null)
                            {
                                sheet.Cells[i + 3, j + 1] = dtgvTienNhapVatTu.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    int bang2 = dtgvTienNhapVatTu.Rows.Count+4;
                    sheet.Range[sheet.Cells[bang2, 1], sheet.Cells[bang2, dtgvTienPhiSuaChua.Columns.Count]].Merge();
                    sheet.Cells[bang2, 1].value = "DOANH THU PHÍ SỬA CHỮA";
                    sheet.Cells[bang2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    //sinh tiêu đề sua chua
                    for (int i = 1; i <= dtgvTienPhiSuaChua.Columns.Count; i++)
                    {
                        sheet.Cells[1+bang2, i] = dtgvTienPhiSuaChua.Columns[i - 1].HeaderText;
                    }
                    //sinh du lieu sua chua
                    for (int i = 0; i < dtgvTienPhiSuaChua.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgvTienPhiSuaChua.Columns.Count; j++)
                        {
                            if (dtgvTienPhiSuaChua.Rows[i].Cells[j].Value != null)
                            {
                                sheet.Cells[i + 2+ bang2, j + 1] = dtgvTienPhiSuaChua.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    //sinh du lieu tong
                    int bang3 = bang2+ dtgvTienPhiSuaChua.Rows.Count +4;
                    sheet.Cells[bang3, 1].value = "Tổng tiền nhập vật vư";
                    sheet.Cells[bang3+1, 1].value = "Doanh Thu";
                    sheet.Cells[bang3, 2].value = lbTongTienNhapVatTu.Text;
                    sheet.Cells[bang3+1, 2].value = lbDoanhThu.Text;
                    //ghi lại
                    wb.SaveAs(fsave.FileName);
                    MessageBox.Show("Xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    app.Quit();
                    wb = null;
                }
            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
//using app = Microsoft.Office.Interop.Excel.Application;

namespace GUI.BaoCao
{
    public partial class UC_BaoCaoTonKho : UserControl
    {
        BUS_TonKho bus_TonKho = new BUS_TonKho();
        private static UC_BaoCaoTonKho _instance;
        public static UC_BaoCaoTonKho Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_BaoCaoTonKho();
                }
                return _instance;
            }
        }
        public void capNhatdtgvTonKho()
        {
            dtgvTonKho.DataSource = null;

            BUS_KiemKeVatTu bus_KiemKe = new BUS_KiemKeVatTu();
            // load bảng vật tư từ database

            DataTable dtThongTinVatTu = bus_KiemKe.BUS_GetThongTinVatTu();

            Exception ex = bus_KiemKe.GetException();
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dtgvTonKho.DataSource = dtThongTinVatTu;

            dtgvTonKho.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
            dtgvTonKho.Columns["Mavattu"].HeaderText = "Mã vật tư";
            dtgvTonKho.Columns["Tenvattu"].HeaderText = "Tên vật tư";
            dtgvTonKho.Columns["Soluong"].HeaderText = "Số lượng còn lại";

            //ẩn cột 

            //dtgvTonKho.Columns["HangSanXuat"].Visible = false;
            //dtgvTonKho.Columns["VatTu"].Visible = false;
            //dtgvTonKho.Columns["SoLuongNhap"].Visible = false;
            //dtgvTonKho.Columns["SoLuongDung"].Visible = false;
            //dtgvTonKho.Columns["SoLuongConLai"].Visible = false;

            //điều chỉnh thứ tự các cột
            //dtgvTonKho.Columns["Tendanhmuc"].DisplayIndex = 0;
            //dtgvTonKho.Columns["Mavattu"].DisplayIndex = 1;
            //dtgvTonKho.Columns["Tenvattu"].DisplayIndex = 2;
            //dtgvTonKho.Columns["Soluong"].DisplayIndex = 3;
            //dtgvTonKho.Columns["SoLuongDung"].DisplayIndex = 4;
            //dtgvTonKho.Columns["SoLuongConLai"].DisplayIndex = 3;
        }
        public void XoaDuLieu()
        {
            dtgvTonKho.Refresh();
        }
        public void UC_BaoCaoTonKho_Load()
        {
            dtpkFrom.Value = DateTime.Now;
            dtpkTo.Value = DateTime.Now;

        }
        public UC_BaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void BtnXemTonKho_Click_1(object sender, EventArgs e)
        {
            if (dtpkFrom.Value == dtpkTo.Value)

            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải khác nhau!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = bus_TonKho.BUS_GetTonKho(dtpkFrom.Value, dtpkTo.Value);

                Exception ex = bus_TonKho.GetException();

                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                dtgvTonKho.DataSource = dt;
                dtgvTonKho.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
                //dtgvTonKho.Columns["Mavattu"].HeaderText = "Mã vật tư";
                dtgvTonKho.Columns["Tenvattu"].HeaderText = "Tên vật tư";
                dtgvTonKho.Columns["Soluongnhap"].HeaderText = "Số lượng nhập";
                dtgvTonKho.Columns["Soluongdung"].HeaderText = "Số lượng dùng";
                dtgvTonKho.Columns["Soluongconlai"].HeaderText = "Số lượng còn lại";
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
                    sheet.Name = "Báo cáo tồn kho";
                    sheet.Columns.ColumnWidth = 25;
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dtgvTonKho.Columns.Count]].Merge();
                    sheet.Cells[1, 1].value = "BÁO CÁO TỒN KHO";
                    sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    //sinh tiêu đề
                    for (int i = 1; i <= dtgvTonKho.Columns.Count; i++)
                    {
                        sheet.Cells[2, i] = dtgvTonKho.Columns[i - 1].HeaderText;
                    }
                    //sinh du lieu
                    for (int i = 0; i < dtgvTonKho.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgvTonKho.Columns.Count; j++)
                        {
                            if (dtgvTonKho.Rows[i].Cells[j].Value != null)
                            {
                                sheet.Cells[i + 3, j + 1] = dtgvTonKho.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
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

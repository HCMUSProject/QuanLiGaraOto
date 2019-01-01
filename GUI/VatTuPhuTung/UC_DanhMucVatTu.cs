using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.VatTuPhuTung
{
    public partial class UC_DanhMucVatTu : UserControl
    {
        private static UC_DanhMucVatTu _instance;
        public static UC_DanhMucVatTu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_DanhMucVatTu();
                }
                return _instance;
            }
        }

        #region Khu vực biến
        private bool isLoaded = false;
        private bool isFocusGridView = false;

        private BUS_DanhMucVatTu bus_DanhMuc = new BUS_DanhMucVatTu();
        #endregion

        public UC_DanhMucVatTu()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            //dtgvDanhMuc.DataSource = null;
            dtgvDanhMuc.Refresh();

            txbDanhMuc.Text = "";
            isLoaded = false;
        }

        private void UC_DanhMucVatTu_CLick(object sender, EventArgs e)
        {
            BtnThem.Enabled = true;
            BtnSua.Enabled = false;

            if (isFocusGridView == true)
            {
                txbDanhMuc.Text = "";
                isFocusGridView = false;
            }
        }

        public void UC_DanhMucVatTu_Load()
        {
            // tắt/ bật các button
            BtnThem.Enabled = true;
            BtnSua.Enabled = false;

            // load dữ liệu từ database
            DataTable dt = bus_DanhMuc.GetDanhMucVatTu();

            Exception ex = bus_DanhMuc.GetException();

            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dtgvDanhMuc.DataSource = dt;

            dtgvDanhMuc.Columns["Maloai"].HeaderText = "Mã danh mục";
            dtgvDanhMuc.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";

            isLoaded = true;
        }

        // ============================ Button event =================================

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string strThemDanhMuc = txbDanhMuc.Text;

            if (strThemDanhMuc == "")
            {
                MessageBox.Show("Tên danh mục không được để trống!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // kiểm tranh danh mục có trùng với danh mục đã có

            foreach(DataGridViewRow row in dtgvDanhMuc.Rows)
            {
                if (row.Cells["Tendanhmuc"].Value.ToString().ToLower() == strThemDanhMuc.ToLower())
                {
                    MessageBox.Show($"Tên danh mục '{ strThemDanhMuc}' bị trùng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            DialogResult rs = MessageBox.Show($"Thêm danh mục {strThemDanhMuc} ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (rs == DialogResult.OK)
            {
                bool isAdded = bus_DanhMuc.ThemDanhMuc(strThemDanhMuc);

                Exception ex = bus_DanhMuc.GetException();

                if (ex != null)
                {
                    MessageBox.Show(ex.Message, "Notification");
                    return;
                }

                if (isAdded == true)
                {
                    DataGridViewRow row = (DataGridViewRow)dtgvDanhMuc.Rows[0].Clone();

                    List<DTO_Danhmucvt> listDanhMuc = bus_DanhMuc.TimKiemDanhMuc(strThemDanhMuc);

                    //row.Cells[0].Value = listDanhMuc[0].MALOAI.ToString();

                    //row.Cells[1].Value = listDanhMuc[0].TENDANHMUC.ToString();

                    //dtgvDanhMuc.Rows.Add(row);

                    XoaDuLieu();

                    UC_DanhMucVatTu_Load();

                    MessageBox.Show($"Thêm thành công danh mục {strThemDanhMuc}!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvDanhMuc.SelectedRows[0];

            int nMaDanhMuc = int.Parse(row.Cells[0].Value.ToString());
            string strTenDanhMuc = row.Cells[1].Value.ToString();

            if (txbDanhMuc.Text == "")
            {
                MessageBox.Show("Tên danh mục không được để trống!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (strTenDanhMuc == txbDanhMuc.Text)
            {
                MessageBox.Show("Tên mới trùng với tên cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult rs = MessageBox.Show($"Sửa danh mục {strTenDanhMuc} thành {txbDanhMuc.Text} ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (rs == DialogResult.OK)
                {
                    DTO_Danhmucvt danhMuc = new DTO_Danhmucvt(nMaDanhMuc, txbDanhMuc.Text);

                    bool isEdited = bus_DanhMuc.SuaDanhMucVatTu(danhMuc);

                    Exception ex = bus_DanhMuc.GetException();

                    if (ex != null)
                    {
                        MessageBox.Show(ex.Message, "Notification");
                        return;
                    }

                    if (isEdited == true)
                    {
                        dtgvDanhMuc.SelectedRows[0].Cells[1].Value = txbDanhMuc.Text;
                        MessageBox.Show($"Đã sửa danh mục {strTenDanhMuc} thành {txbDanhMuc.Text} !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa!", "Thông báo");
                    }
                }
            }
        }

        private void dtgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isLoaded == true)
            {
                BtnThem.Enabled = false;
                BtnSua.Enabled = true;

                isFocusGridView = true;

                txbDanhMuc.Text = dtgvDanhMuc.SelectedRows[0].Cells["Tendanhmuc"].Value.ToString();
            }
        }
    }
    
}

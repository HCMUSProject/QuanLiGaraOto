using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.DichVuSuaChua
{
    public partial class UC_LapPhieuSuaChua : UserControl
    {
        BUS_Lapphieusuachua lpsc = new BUS_Lapphieusuachua();
        private static UC_LapPhieuSuaChua _instance;
        public static UC_LapPhieuSuaChua Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_LapPhieuSuaChua();
                }
                return _instance;
            }
        }

        public UC_LapPhieuSuaChua()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            txbMaPhieu.Text = "";
            txbDienThoai.Text = "";
            txbTongTien.Text = "";

            cmbBienSoXe.Text = "";
            cmbBienSoXe.DataSource = null;
            cmbBienSoXe.Items.Clear();
            cmbBienSoXe.SelectedIndex = -1;

            cmbKhachHang.Text = "";
            cmbKhachHang.DataSource = null;
            cmbKhachHang.Items.Clear();
            cmbKhachHang.SelectedIndex = -1;

            cmbLoaiXe.Text = "";
            cmbLoaiXe.DataSource = null;
            cmbLoaiXe.Items.Clear();
            cmbLoaiXe.SelectedIndex = -1;

            cmbNhanVienSuaChua.Text = "";
            cmbNhanVienSuaChua.DataSource = null;
            cmbNhanVienSuaChua.Items.Clear();
            cmbNhanVienSuaChua.SelectedIndex = -1;
            if (dtgvChiTietSuaChua.DataSource != null)
            {
                dtgvChiTietSuaChua.DataSource = null;
            }
            else
            {
                dtgvChiTietSuaChua.Rows.Clear();
            }
            dtgvChiTietSuaChua.Refresh();
        }

        private void UC_LapPhieuSuaChua_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnSub.Enabled = false;
            dtgvChiTietSuaChua.AllowUserToAddRows = false;
            txbDienThoai.Enabled = false;
            cmbLoaiXe.Enabled = false;
            cmbBienSoXe.Enabled = false;
            cmbNhanVienSuaChua.Enabled = false;
            this.txbTongTien.Text = "0";
            //  dtgvChiTietSuaChua.Enabled = false;
            for (int i = 0; i < lpsc.getKhachhang().Rows.Count; i++)
            {
                cmbKhachHang.Items.Add(lpsc.getKhachhang().Rows[i][0] + " - " + lpsc.getKhachhang().Rows[i][1]);
            }
            string tmp = lpsc.getMaxid();
            if (tmp == "")
                tmp = "-1";
            int id = Int32.Parse(tmp) + 1;

            txbMaPhieu.Text = id.ToString();
        }
        /// <summary>
        /// load lại khi change form
        /// </summary>
        public void Load2()
        {
            btnAdd.Enabled = false;
            btnSub.Enabled = false;

            dtgvChiTietSuaChua.AllowUserToAddRows = false;
            this.txbTongTien.Text = "0";
            txbDienThoai.Enabled = false;
            cmbLoaiXe.Enabled = false;
            cmbBienSoXe.Enabled = false;
            cmbNhanVienSuaChua.Enabled = false;
            dtgvChiTietSuaChua.Enabled = false;
            for (int i = 0; i < lpsc.getKhachhang().Rows.Count; i++)
            {
                cmbKhachHang.Items.Add(lpsc.getKhachhang().Rows[i][0] + " - " + lpsc.getKhachhang().Rows[i][1]);
            }
            string tmp = lpsc.getMaxid();
            if (tmp == "")
                tmp = "-1";
            int id = Int32.Parse(tmp) + 1;

            txbMaPhieu.Text = id.ToString();
        }
        /// <summary>
        /// get cmnd từ cmbKhachhang
        /// </summary>
        /// <returns></returns>
        public string getCMND()
        {
            return this.cmbKhachHang.GetItemText(this.cmbKhachHang.SelectedItem).Substring((
                (this.cmbKhachHang.GetItemText(this.cmbKhachHang.SelectedItem)).LastIndexOf('-') + 1)).Trim();
        }
        /// <summary>
        /// get cmnd từ cmbNhanviensuachua
        /// </summary>
        /// <returns></returns>
        public string getCMNDnhanvien()
        {
            return this.cmbNhanVienSuaChua.GetItemText(this.cmbNhanVienSuaChua.SelectedItem).Substring((
               (this.cmbNhanVienSuaChua.GetItemText(this.cmbNhanVienSuaChua.SelectedItem)).LastIndexOf('-') + 1)).Trim();

        }
        /// <summary>
        /// get tên hiệu xe từ cmbHieuxe
        /// </summary>
        /// <returns></returns>
        public string getHieuxe()
        {
            return this.cmbLoaiXe.GetItemText(this.cmbLoaiXe.SelectedItem);
        }
        /// <summary>
        /// get biển số từ cmbBienso
        /// </summary>
        /// <returns></returns>
        public string getBienso()
        {
            return this.cmbBienSoXe.GetItemText(this.cmbBienSoXe.SelectedItem);
        }
        /// <summary>
        /// get value trong cmbNhanviensuachua
        /// </summary>
        /// <returns></returns>
        public string getNhanviensua()
        {
            return this.cmbNhanVienSuaChua.GetItemText(this.cmbNhanVienSuaChua.SelectedItem);
        }
        /// <summary>
        /// get mã vật tư từ cmbDatagridview
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int getMavattu(int row)
        {
            string tmp = this.dtgvChiTietSuaChua.Rows[row].Cells[1].Value.ToString();
            return Int32.Parse(tmp.Substring(tmp.LastIndexOf('-') + 1).Trim());
        }
        /// <summary>
        /// get số lượng từ txbdatagridview
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int getSoluong(int row)
        {
            string tmp = this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value.ToString();
            return Int32.Parse(tmp.Trim());
        }
        /// <summary>
        /// get loại dịch vụ từ cmbdatagirdview
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public string getLoaidichvu(int row)
        {
            string tmp = this.dtgvChiTietSuaChua.Rows[row].Cells[0].Value.ToString();
            return tmp;
        }

        /// <summary>
        /// handle event cmbKhachHang_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)

        {
            cmbLoaiXe.Text = "";
           

            

            txbDienThoai.Text = lpsc.getSodienthoai(getCMND()).Rows[0][0].ToString();
            // txbDienThoai.Enabled = true;
        }

        /// <summary>
        /// handle event txbDienThoai_TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbDienThoai_TextChanged(object sender, EventArgs e)
        {
            cmbLoaiXe.DataSource = null;
            cmbLoaiXe.Items.Clear();
            cmbLoaiXe.SelectedIndex = -1;
            cmbLoaiXe.Enabled = true;
            foreach (DataRow dr in lpsc.getHieuxe(getCMND()).Rows)
            {
                cmbLoaiXe.Items.Add(dr["Tenhieuxe"].ToString());
            }
        }
        /// <summary>
        /// handle event cmbBienSoXe_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBienSoXe_SelectedIndexChanged(object sender, EventArgs e)

        {
            cmbNhanVienSuaChua.Text = "";
            cmbNhanVienSuaChua.DataSource = null;
            cmbNhanVienSuaChua.Items.Clear();
            cmbNhanVienSuaChua.SelectedIndex = -1;

            cmbNhanVienSuaChua.Enabled = true;
            for (int i = 0; i < lpsc.getNhanvien().Rows.Count; i++)
            {
                cmbNhanVienSuaChua.Items.Add(lpsc.getNhanvien().Rows[i][0] + " - " + lpsc.getNhanvien().Rows[i][1]);
            }
        }
        /// <summary>
        /// handle event cmbLoaiXe_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBienSoXe.Text = "";
            cmbBienSoXe.DataSource = null;
            cmbBienSoXe.Items.Clear();
            cmbBienSoXe.SelectedIndex = -1;
            cmbBienSoXe.Enabled = true;
            foreach (DataRow dr in lpsc.getBienso(getCMND(), getHieuxe()).Rows)
            {
                cmbBienSoXe.Items.Add(dr["Bienso"].ToString());
            }
        }
        /// <summary>
        /// handle event cmbNhanVienSuaChua_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNhanVienSuaChua_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiDichVu.DataSource = null;
            LoaiDichVu.Items.Clear();
            dtgvChiTietSuaChua.Enabled = true;
            foreach (DataRow dr in lpsc.getDichvu().Rows)
            {
                LoaiDichVu.Items.Add(dr["Tendichvu"].ToString());
            }
            btnAdd.Enabled = true;
            btnSub.Enabled = true;

        }
        /// <summary>
        /// load data vào collection auto complete textbox control
        /// </summary>
        /// <param name="autoCol"></param>
        private void LoadLocalDataCollection(AutoCompleteStringCollection autoCol)
        {
            for (int i = 0; i < lpsc.getVattu().Rows.Count; i++)
            {
                autoCol.Add(lpsc.getVattu().Rows[i][0].ToString() + " - " + lpsc.getVattu().Rows[i][1].ToString());
            }
        }
        /// <summary>
        /// handel event BtnLapPhieu_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLapPhieu_Click(object sender, EventArgs e)
        {
            if (getCMND() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (getHieuxe() == "")
            {
                MessageBox.Show("Vui lòng chọn hiệu xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (getBienso() == "")
            {
                MessageBox.Show("Vui lòng chọn biển số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (getNhanviensua() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Checkfullrow() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(dtgvChiTietSuaChua.RowCount<=0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if(lpsc.CheckExitsCar(getBienso())==true)
            {
                MessageBox.Show("Hóa đơn cho xe này vẫn chưa thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XoaDuLieu();
            }
            else
            {
                DTO_Donhangsuachua dh = new DTO_Donhangsuachua(0, Int32.Parse(lpsc.getManhanvien(getCMNDnhanvien())), Int32.Parse(lpsc.getManhanvien(getCMNDnhanvien())),
                    Int32.Parse(lpsc.getMakhachhang(getCMND())),
                  Int32.Parse(lpsc.getIDxe(getBienso())), DateTime.Now, Int32.Parse(txbTongTien.Text));

                DialogResult result;
                if (lpsc.lapdonhang(dh))
                {
                    result = MessageBox.Show("Thêm đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        for (int i = 0; i < dtgvChiTietSuaChua.RowCount; i++)
                        {
                            DTO_Chitietdonhang ct = new DTO_Chitietdonhang(0, Int32.Parse(txbMaPhieu.Text), getMavattu(i), getSoluong(i), Int32.Parse(lpsc.getMadichvu(getLoaidichvu(i))));
                            if (ct == null)
                            {
                                i++;
                            }
                            else
                            {
                                if (lpsc.chitietdonhang(ct) == false)
                                    MessageBox.Show("Fail1");
                                int tmp = Int32.Parse(this.dtgvChiTietSuaChua.Rows[i].Cells[2].Value.ToString());
                                int tmp2 = Int32.Parse(lpsc.getSoluongvattu(getMavattu(i)));
                                if (lpsc.updateVattu(getMavattu(i), tmp2 - tmp) == false)
                                    MessageBox.Show("Fail2");

                            }
                        }
                        XoaDuLieu();
                        UC_LapPhieuSuaChua_Load(sender, e);
                    }


                }
                else
                {
                    result = MessageBox.Show("Thêm đơn hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgvChiTietSuaChua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// handle event "auto complete textbox dtgv control"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvChiTietSuaChua_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int column = dtgvChiTietSuaChua.CurrentCell.ColumnIndex;

            string headerText = dtgvChiTietSuaChua.Columns[column].HeaderText;
            // string titleText = dtgvChiTietSuaChua.Columns[1].HeaderText;
            if (headerText.Equals("Phụ tùng"))
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    AutoCompleteStringCollection autoCol = new AutoCompleteStringCollection();
                    LoadLocalDataCollection(autoCol);
                    autoText.AutoCompleteCustomSource = autoCol;
                }
            }
            else if (headerText.Equals("Loại dịch vụ"))
            {
                return;
            }
            else
            {
                TextBox autoText = e.Control as TextBox;
                autoText.AutoCompleteMode = AutoCompleteMode.None;
            }
        }
        //public bool CheckrowIsempty(int row)
        //{
        //    return (this.dtgvChiTietSuaChua.Rows[row].Cells[0] == null || this.dtgvChiTietSuaChua.Rows[row].Cells[1] ==
        //        null || this.dtgvChiTietSuaChua.Rows[row].Cells[2] == null) ? true : false;
        //}
        
        private void dtgvChiTietSuaChua_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// check a row in dtgv is full?
        /// </summary>
        /// <returns></returns>
        public bool Checkfullrow()
        {
            if (dtgvChiTietSuaChua.RowCount <= 0) return false;
            if (dtgvChiTietSuaChua.Rows[0].Cells[0].Value==null)
                return false;
            int row = dtgvChiTietSuaChua.CurrentCell.RowIndex;
            if (this.dtgvChiTietSuaChua.Rows[row].Cells[0].Value != null && this.dtgvChiTietSuaChua.Rows[row].Cells[1].Value != null
               && this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value != null)
                return true;
            if (this.dtgvChiTietSuaChua.Rows[row].Cells[0].Value != null)
                return true;
            return false;
        }

        /// <summary>
        /// handle event "khi 1 ô trong datagridview editing"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvChiTietSuaChua_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //   int row = dtgvChiTietSuaChua.CurrentCell.RowIndex;
            this.txbTongTien.Text = "0";
            dtgvChiTietSuaChua.AllowUserToAddRows = false;
            // int soluongtam = 0;
            for (int row = 0; row < dtgvChiTietSuaChua.RowCount; row++)
            {
                
               // int soluongtam = Int32.Parse(lpsc.getSoluongvattu(getMavattu(row)));
                if (this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value != null)
                {
                    int soluongtam = Int32.Parse(lpsc.getSoluongvattu(getMavattu(row)));
                    for (int temp = 0; temp < row; temp++)
                    {
                        if (getMavattu(temp) == getMavattu(row))
                        {
                            soluongtam -= Int32.Parse(this.dtgvChiTietSuaChua.Rows[temp].Cells[2].Value.ToString());
                        }
                    }
                    string tmp = this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value.ToString();
                    if(soluongtam<Int32.Parse(tmp))
                    {
                        MessageBox.Show("Vượt quá số lượng vật tư trong kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.dtgvChiTietSuaChua.Rows[row].Cells[3].Value = null;
                        this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value = null;
                        this.dtgvChiTietSuaChua.Rows[row].Cells[2].Selected = true;
                        this.dtgvChiTietSuaChua.MultiSelect = false;
                    }
                }
                if (this.dtgvChiTietSuaChua.Rows[row].Cells[0].Value == null || this.dtgvChiTietSuaChua.Rows[row].Cells[1].Value == null
                || this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value == null)
                {
                    this.dtgvChiTietSuaChua.Rows[row].Cells[3].Value = null;
                    if (this.dtgvChiTietSuaChua.Rows[row].Cells[0].Value == null)
                    {
                        this.dtgvChiTietSuaChua.Rows[row].Cells[1].Value = null;
                        this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value = null;

                        this.dtgvChiTietSuaChua.Rows[row].Cells[1].ReadOnly = true;
                        this.dtgvChiTietSuaChua.Rows[row].Cells[2].ReadOnly = true;

                    }
                    else
                    {
                        //if (dtgvChiTietSuaChua.CurrentCell.ColumnIndex > 0)
                        //{
                        //    this.dtgvChiTietSuaChua.Rows[row + 1].Cells[1].ReadOnly = true;
                        //    this.dtgvChiTietSuaChua.Rows[row + 1].Cells[2].ReadOnly = true;
                        //    this.dtgvChiTietSuaChua.Rows[row + 1].Cells[0].ReadOnly = true;
                        //}

                        this.dtgvChiTietSuaChua.Rows[row].Cells[1].ReadOnly = false;
                        if (this.dtgvChiTietSuaChua.Rows[row].Cells[1].Value == null)
                        {
                            this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value = null;

                            this.dtgvChiTietSuaChua.Rows[row].Cells[2].ReadOnly = true;
                        }
                        else this.dtgvChiTietSuaChua.Rows[row].Cells[2].ReadOnly = false;
                    }
                }
                else if (this.dtgvChiTietSuaChua.Rows[row].Cells[0].Value != null && this.dtgvChiTietSuaChua.Rows[row].Cells[1].Value != null
                && this.dtgvChiTietSuaChua.Rows[row].Cells[2].Value != null)
                {


                    int soluong = getSoluong(row);
                    int giathanh = Int32.Parse(lpsc.getGiathanh(getMavattu(row)));
                    int giadichvu = Int32.Parse(lpsc.getGiadichvu(getLoaidichvu(row)));
                    int bill = soluong * giathanh*2 + giadichvu;


                    this.dtgvChiTietSuaChua.Rows[row].Cells[3].Value = bill.ToString();
                    this.txbTongTien.Text = (Int32.Parse(this.txbTongTien.Text) + Int32.Parse(this.dtgvChiTietSuaChua.Rows[row].Cells[3].Value.ToString())).ToString();
                    //this.dtgvChiTietSuaChua.NotifyCurrentCellDirty(true);
                    //dtgvChiTietSuaChua.Refresh();
                    //if (dtgvChiTietSuaChua.CurrentCell.ColumnIndex > 0)
                    //{
                    //    this.dtgvChiTietSuaChua.Rows[row + 1].Cells[1].ReadOnly = true;
                    //    this.dtgvChiTietSuaChua.Rows[row + 1].Cells[2].ReadOnly = true;
                    //    this.dtgvChiTietSuaChua.Rows[row + 1].Cells[0].ReadOnly = false;
                    //}
                }

            }


        }

        /// <summary>
        /// handle event click btnAdd (để thêm 1 dòng vào dtgv)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgvChiTietSuaChua.AllowUserToAddRows = true;
        }

        /// <summary>
        /// handle event click btnSub (để xóa 1 dòng khỏi dtgv)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtgvChiTietSuaChua.SelectedRows)
            {
                if (item.IsNewRow) //nếu đó là dòng mới của dtgv
                    this.dtgvChiTietSuaChua.AllowUserToAddRows = false;
               else  dtgvChiTietSuaChua.Rows.RemoveAt(item.Index);
            }
        }

        //private void cmbNhanVienSuaChua_Click(object sender, EventArgs e)
        //{
        //    cmbNhanVienSuaChua.Text = "";
        //    cmbNhanVienSuaChua.DataSource = null;
        //    cmbNhanVienSuaChua.Items.Clear();
        //    cmbNhanVienSuaChua.SelectedIndex = -1;

        //    for (int i = 0; i < lpsc.getNhanvien().Rows.Count; i++)
        //    {
        //        cmbNhanVienSuaChua.Items.Add(lpsc.getNhanvien().Rows[i][0] + " - " + lpsc.getNhanvien().Rows[i][1]);
        //    }
        //}
    }
}

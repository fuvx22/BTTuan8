using KetNoiCSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTuan8
{
    public partial class FormSV : Form
    {
        SinhVien selectedSV = new SinhVien();
        List<SinhVien> DSSV;
        public FormSV()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Title", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                KetNoiCSDL.XoaSV(selectedSV.MaSo);
                loadDataGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedSV.MaSo = (int)selectedRow.Cells[0].Value;
                selectedSV.HoTen = (string)selectedRow.Cells[1].Value;
                selectedSV.NgaySinh = (DateTime)selectedRow.Cells[2].Value;
                selectedSV.GioiTinh = (Boolean)selectedRow.Cells[3].Value;
                selectedSV.DiaChi = (string)selectedRow.Cells[4].Value;
                selectedSV.DienThoai = (int)selectedRow.Cells[5].Value;
                selectedSV.MaKhoa = (string)selectedRow.Cells[6].Value;


            }

            txtMaSo.Text = selectedSV.MaSo.ToString();
            txtHoTen.Text = selectedSV.HoTen;
            txtNgaySinh.Text = selectedSV.NgaySinh.ToString();
            checkBoxGioiTinh.Checked = selectedSV.GioiTinh;
            txtDiaChi.Text = selectedSV.DiaChi;
            txtDienThoai.Text = selectedSV.DienThoai.ToString();
            txtMaKhoa.Text = selectedSV.MaKhoa;

        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            DSSV = KetNoiCSDL.getDSSV();
            dataGridView1.DataSource = DSSV;
            dataGridView1.Refresh();
        }


        private void themBtn_Click(object sender, EventArgs e)
        {
            clearTxtField();
            txtMaSo.Focus();
        }

        private void clearTxtField()
        {
            txtMaSo.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            checkBoxGioiTinh.Checked = false;
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaKhoa.Text = "";
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            try
            {

            int maSo = Convert.ToInt32(txtMaSo.Text);
            string hoTen = Convert.ToString(txtHoTen.Text);
            DateTime ngaySinh = Convert.ToDateTime(txtNgaySinh.Text);
            Boolean gioiTinh = Convert.ToBoolean(checkBoxGioiTinh.Checked);
            string diaChi = Convert.ToString(txtDiaChi.Text);
            int dienThoai = Convert.ToInt32(txtDienThoai.Text);
            string maKhoa = Convert.ToString(txtMaKhoa.Text);

            SinhVien newSinhVien = new SinhVien(maSo, hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, maKhoa);

            foreach(SinhVien sv in DSSV)
                {
                    if (sv.MaSo.Equals(newSinhVien.MaSo))
                    {
                       Boolean b = KetNoiCSDL.suaSV(newSinhVien);
                        if (!b)
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                        clearTxtField();
                        loadDataGrid();

                        return;
                    }
                }

             Boolean v = KetNoiCSDL.ThemSV(newSinhVien);
             clearTxtField();
                if (!v)
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            
            loadDataGrid();

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Không được bỏ trống hoặc nhập sai định dạng");
            }



        }
    }
}

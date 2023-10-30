using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL
{
    public class SinhVien
    {
        public SinhVien() { }

        public SinhVien(int maSo, string hoTen, DateTime ngaySinh, bool gioiTinh, string diaChi, int dienThoai, string maKhoa)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            MaKhoa = maKhoa;
        }

        public int MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int DienThoai { get; set; }
        public string MaKhoa { get; set; }

    }
}

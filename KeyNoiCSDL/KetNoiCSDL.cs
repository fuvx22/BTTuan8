using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL
{
    public class KetNoiCSDL
    {
        public static object MessageBox { get; private set; }

        public static MySqlConnection getConnection()
        {
            string connectionString = "server=localhost;user=root;password=;database=quanlisinhvien;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }

        public static List<SinhVien> getDSSV()
        {
            List<SinhVien> KetQua = new List<SinhVien>();
            try
            {
                string sql = "SELECT * FROM sinhvien";

                MySqlConnection connection = getConnection();
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int maSo = reader.GetInt32("MaSo");
                    string hoTen = reader.GetString("HoTen");
                    DateTime ngaySinh = reader.GetDateTime("NgaySinh");
                    bool gioiTinh = reader.GetBoolean("GioiTinh");
                    string diaChi = reader.GetString("DiaChi");
                    int dienThoai = reader.GetInt32("DienThoai");
                    string maKhoa = reader.GetString("MaKhoa");

                    KetQua.Add(new SinhVien(maSo, hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, maKhoa));

                }

                connection.Close();

                return KetQua;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool ThemSV(SinhVien sinhVien)
        {
            try
            {

                string sql = "INSERT INTO sinhvien " +
                 "VALUE (@MaSo, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @MaKhoa)";


                MySqlConnection connection = getConnection();
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@MaSo", sinhVien.MaSo);
                command.Parameters.AddWithValue("@HoTen", sinhVien.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", sinhVien.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", sinhVien.DiaChi);
                command.Parameters.AddWithValue("@DienThoai", sinhVien.DienThoai);
                command.Parameters.AddWithValue("@MaKhoa", sinhVien.MaKhoa);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;

            }


        }

        public static bool suaSV(SinhVien sinhVien)
        {
            try
            {
                string sql = "UPDATE sinhvien " +
                    $"SET HoTen= @HoTen, " +
                    $" NgaySinh=@NgaySinh, " +
                    $" GioiTinh=@GioiTinh, " +
                    $" DiaChi= @DiaChi, " +
                    $" MaKhoa= @MaKhoa " +
                    $" WHERE MaSo = @MaSo ";

                MySqlConnection connection = getConnection();
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@MaSo", sinhVien.MaSo);
                command.Parameters.AddWithValue("@HoTen", sinhVien.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", sinhVien.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", sinhVien.DiaChi);
                command.Parameters.AddWithValue("@DienThoai", sinhVien.DienThoai);
                command.Parameters.AddWithValue("@MaKhoa", sinhVien.MaKhoa);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void XoaSV(int MaSo)
        {
            string sql = "DELETE FROM sinhvien WHERE MaSo= @MaSo ";

            MySqlConnection connection = getConnection();
            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();

            command.Parameters.AddWithValue("@MaSo", MaSo);
            command.ExecuteNonQuery();

            connection.Close();

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_898_TruongAnhVu_Tuan5
{
    class NhanVienKinhDoanh : NhanVien
    {
        private double DoanhSoToiThieu;
        private double DoanhSoTheoThang;
        public NhanVienKinhDoanh()
            : base()
        {
            DoanhSoToiThieu = 0.0;
            DoanhSoTheoThang = 0.0;
        }
        public NhanVienKinhDoanh(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, double DoanhSoToiThieu, double DoanhSoTheoThang)
            : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.DoanhSoToiThieu = DoanhSoToiThieu;
            this.DoanhSoTheoThang = DoanhSoTheoThang;
        }
        public override string XepLoai()
        {
            if (DoanhSoTheoThang >= DoanhSoToiThieu * 2)
                return "A";
            else if (DoanhSoTheoThang >= DoanhSoToiThieu)
                return "B";
            else if (DoanhSoTheoThang >= DoanhSoToiThieu / 2)
                return "C";
            else
                return "D";
        }
        public double HoaHong()
        {
            if (DoanhSoTheoThang > DoanhSoToiThieu)
            {
                return (DoanhSoTheoThang - DoanhSoToiThieu) * 0.15;
            }
            else
                return 0.0;
        }
        public override double Luong()
        {
            return (HeSoLuong * LuongCoBan) + HoaHong();
        }
        //public override void Nhap()
        //{
        //    base.Nhap();
        //    Console.WriteLine("Nhập doanh số tối thiểu");
        //    DoanhSoToiThieu = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Nhập doanh số theo tháng");
        //    DoanhSoTheoThang = double.Parse(Console.ReadLine());
        //}
        public override void Xuat()
        {
            Console.WriteLine("===============NHÂN VIÊN KINH DOANH===============");
            base.Xuat();
            Console.WriteLine("Doanh số tối thiểu là: {0}", DoanhSoToiThieu);
            Console.WriteLine("Doanh số theo tháng là: {0}", DoanhSoTheoThang);
            Console.WriteLine("Xếp loại là: {0}", XepLoai());
            Console.WriteLine("Thu nhập là: {0:f}", ThuNhap());

        }
    }
}

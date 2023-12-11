using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_898_TruongAnhVu_Tuan5
{
    class NhanVienSanXuat : NhanVien
    {
        int soNgayNghi;
        static double PhuCap = 0.1;
        public int SoNgayNghi
        {
            get { return soNgayNghi; }
            set { soNgayNghi = value; }
        }

        public NhanVienSanXuat()
            : base()
        {
            SoNgayNghi = 0;
        }
        public NhanVienSanXuat(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, int SoNgayNghi)
            : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.SoNgayNghi = SoNgayNghi;
        }
        public override string XepLoai()
        {
            if (soNgayNghi <= 1)
                return "A";
            else if (soNgayNghi <= 3)
                return "B";
            else if (soNgayNghi <= 5)
                return "C";
            else
                return "D";
        }
        public override double Luong()
        {
            return heSoLuong * luongCoBan * (1 + NhanVienSanXuat.PhuCap);
        }
        //public override void Nhap()
        //{
        //    base.Nhap();
        //    Console.WriteLine("Nhập số ngày nghỉ");
        //    SoNgayNghi = int.Parse(Console.ReadLine());
        //}
        public override void Xuat()
        {
            Console.WriteLine("===============NHÂN VIÊN SẢN XUẤT===============");
            base.Xuat();
            Console.WriteLine("So ngày nghỉ là: {0}", soNgayNghi);
            Console.WriteLine("Xếp loại là: {0}", XepLoai());
            Console.WriteLine("Thu nhập là: {0:f}", ThuNhap());
        }
    }
}

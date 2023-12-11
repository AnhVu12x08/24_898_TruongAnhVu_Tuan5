using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_898_TruongAnhVu_Tuan5
{
    class NhanVienQuanLy : NhanVien
    {
        string chucVu;
        double heSoChucVu;
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        public double HeSoChucVu
        {
            get { return heSoChucVu; }
            set { heSoChucVu = value; }
        }
        public NhanVienQuanLy()
            : base()
        {
            ChucVu = "";
            HeSoChucVu = 0.0;
        }
        public NhanVienQuanLy(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, string ChucVu, double HeSoChucVu)
            : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.ChucVu = ChucVu;
            this.HeSoChucVu = HeSoChucVu;
        }
        public override string XepLoai()
        {
            return "A";
        }
        public double PhuCapChucVu()
        {
            return heSoChucVu * 1100;
        }
        public override double Luong()
        {
            return (heSoLuong * luongCoBan) + PhuCapChucVu();
        }

        //public void Nhap()
        //{
        //    base.Nhap();
        //    Console.WriteLine("Nhập chức vụ");
        //    ChucVu = Console.ReadLine();
        //    Console.WriteLine("Nhập hệ số chức vụ");
        //    HeSoChucVu = double.Parse(Console.ReadLine());
        //}
        public override void Xuat()
        {
            Console.WriteLine("===============NHÂN VIÊN QUẢN LÝ===============");
            base.Xuat();
            Console.WriteLine("Chức vụ là: {0}", chucVu);
            Console.WriteLine("Hệ số chức vụ là: {0}", heSoChucVu);
            Console.WriteLine("Xếp loại là: {0}", XepLoai());
            Console.WriteLine("Thu nhập là: {0:f}", ThuNhap());
        }
    }
}

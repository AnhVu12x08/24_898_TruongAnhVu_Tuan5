using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_898_TruongAnhVu_Tuan5
{
    abstract class NhanVien
    {
        protected string maSo;
        protected string hoTen;
        protected string ngaySinh;
        protected string gioiTinh;
        protected int thamNien;
        protected double luongCoBan = 1300000.0;
        protected double heSoLuong;
        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public int ThamNien
        {
            get { return thamNien; }
            set { thamNien = value; }
        }
        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }



        public NhanVien()
        {
            MaSo = "Chưa xác định";
            HoTen = "Chưa xác định";
            NgaySinh = "Chưa xác định";
            GioiTinh = "Chưa xác định";
            ThamNien = 0;
            HeSoLuong = 0.0;
        }
        public NhanVien(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double HeSoLuong)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.ThamNien = ThamNien;
            this.HeSoLuong = HeSoLuong;
        }
        public double PhuCapThamNien()
        {
            if (thamNien >= 5)
                return thamNien * luongCoBan / 100;
            else return 0;
        }
        public abstract string XepLoai();
        public abstract double Luong();
        public double ThuNhap()
        {
            if (XepLoai() == "A")
                return Luong() + PhuCapThamNien();
            else if (XepLoai() == "B")
                return Luong() * 0.75 + PhuCapThamNien();
            else if (XepLoai() == "C")
                return Luong() * 0.50 + PhuCapThamNien();
            else
                return Luong() * 0.0 + PhuCapThamNien();
        }
        //public virtual void Nhap()
        //{
        //    Console.WriteLine("============NHẬP THÔNG TIN============ ");
        //    Console.WriteLine("Nhập mã số: ");
        //    MaSo = Console.ReadLine();
        //    Console.WriteLine("Nhập họ tên: ");
        //    HoTen = Console.ReadLine();
        //    Console.WriteLine("Nhập ngày sinh: ");
        //    NgaySinh = Console.ReadLine();
        //    Console.WriteLine("Nhập giới tính: ");
        //    GioiTinh = Console.ReadLine();
        //    Console.WriteLine("Nhập thâm niên: ");
        //    ThamNien = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Nhập hệ số lương: ");
        //    HeSoLuong = double.Parse(Console.ReadLine());
        //}
        public virtual void Xuat()
        {
            Console.WriteLine("Mã số là: {0}", maSo);
            Console.WriteLine("Họ tên là: {0}", hoTen);
            Console.WriteLine("Ngày sinh là: {0}", ngaySinh);
            Console.WriteLine("Giới tính là: {0}", gioiTinh);
            Console.WriteLine("Thâm niên là: {0}", thamNien);
            Console.WriteLine("Hệ số lương là: {0}", heSoLuong);
        }
    }
}

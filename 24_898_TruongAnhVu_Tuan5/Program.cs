using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_898_TruongAnhVu_Tuan5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.InputEncoding = UnicodeEncoding.Unicode;

            DSNV ds = new DSNV();
            ds.DocXml(@"..\..\DSNhanvien.xml");
            ds.XuatXML();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("TỔNG THU NHẬP LÀ {0}", ds.TongLuong());
            Console.WriteLine("-----------------------NHÂN VIÊN CÓ THU NHẬP CAO NHẤT------------------------------------ ");
            ds.DsLuongCaoNhat();
            Console.WriteLine("-----------------------NHÂN VIÊN CÓ THU NHẬP TRÊN 10 TRIỆU---------------------------------- ");
            ds.DsThuNhapTren10();
            Console.WriteLine("-----------------------ĐẾM NHÂN VIÊN CÓ HỆ SỐ PHỤ CẤP THÂM NIÊN-------------------------------");
            Console.WriteLine("{0}", ds.DemNhanVienCoPhuCapThamNien());
            Console.WriteLine("-----------------------NHÂN VIÊN CÓ THÂM NIÊN LỚN HƠN 10---------------------------------- ");
            ds.DsThamNienLonHon10();
            Console.ReadKey();

        }
    }
}

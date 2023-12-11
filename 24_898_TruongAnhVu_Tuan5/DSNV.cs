using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _24_898_TruongAnhVu_Tuan5
{
    class DSNV
    {
        List<NhanVien> ds;
        
        public List<NhanVien> Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        public DSNV()   
        {
            ds = new List<NhanVien>();
        }

        public void DocXml(string filepath)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filepath);

            XmlNodeList nodelist = read.SelectNodes("/danhsachnhanvien/nhanvien");
            foreach (XmlNode node in nodelist)
            {
                NhanVien nv;
                string mnv = node["maso"].InnerText;
                string ten = node["hoten"].InnerText;
                string ns = node["ngaysinh"].InnerText;
                string gt = node["gioitinh"].InnerText;
                int tn = int.Parse(node["maso"].InnerText);
                double hsl = double.Parse(node["hesoluong"].InnerText);

                int loai = int.Parse(node["loai"].InnerText);
                if (loai == 1)
                {
                    int snn = int.Parse(node["songaynghi"].InnerText);
                    nv = new NhanVienSanXuat(mnv, ten, ns, gt, tn, hsl, snn);
                }
                else if (loai == 2)
                {
                    double dstt = double.Parse(node["doanhsotoithieu"].InnerText);
                    double dsttg = double.Parse(node["doanhsotheothang"].InnerText);
                    nv = new NhanVienKinhDoanh(mnv, ten, ns, gt, tn, hsl, dstt, dsttg);
                }
                else
                {
                    string cv = node["chucvu"].InnerText;
                    double hscv = double.Parse(node["hesochucvu"].InnerText);
                    nv = new NhanVienQuanLy(mnv, ten, ns, gt, tn, hsl, cv, hscv);
                }
                ds.Add(nv);
            }
        }
        public void XuatXML()
        {
            foreach (NhanVien nv in ds)
            {
                nv.Xuat();
            }
        }
        //tính tổng lương của các nhân viên
        public double TongLuong()
        {
            double tong = 0;
            foreach (NhanVien nv in ds)
            {
                tong += nv.Luong();
            }
            return tong;
        }
        //danh sách nhân viên có thu nhập trên 10 triệu
        public void DsThuNhapTren10()
        {
            foreach (NhanVien nv in ds)
            {
                if (nv.ThuNhap() > 10000000)
                    nv.Xuat();
            }
        }
        //danh sách nhân viên có lương cao nhất
        public void DsLuongCaoNhat()
        {
            double max = ds[0].Luong();
            foreach (NhanVien nv in ds)
            {
                if (nv.Luong() > max)
                    max = nv.Luong();
            }
            foreach (NhanVien nv in ds)
            {
                if (nv.Luong() == max)
                    nv.Xuat();
            }
        }
        //Đếm số nhân viên có  phụ cấp thâm niên
        public int DemNhanVienCoPhuCapThamNien()
        {
            int dem = 0;
            foreach (NhanVien nv in ds)
            {
                if (nv.PhuCapThamNien() > 0)
                    dem++;
            }
            return dem;
        }
        //danh sách nhân viên có thâm niên lớn hơn 10 năm
        public void DsThamNienLonHon10()
        {
            foreach (NhanVien nv in ds)
            {
                if (nv.ThamNien > 10)
                    nv.Xuat();
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    abstract class BatDS
    {
        private string ma;

        protected string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private double cd;

        protected double Cd
        {
            get { return cd; }
            set { cd = value; }
        }
        private double cr;

        protected double Cr
        {
            get { return cr; }
            set { cr = value; }
        }
        public BatDS()
        {
            Ma = string.Empty;
            Cd = 0;
            Cr = 0;
        }
        public BatDS(string ma, double cd, double cr)
        {
            Ma = ma;
            Cd = cd;
            Cr = cd;
        }
        public abstract double GiaBan();
        public double DienTich()
        {
            return cd * cr;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma: {0} \tChieu Dai: {1} \tChieu rong: {2} \tGia ban: {3}",ma , cd, cr, GiaBan());
        }
    }
}

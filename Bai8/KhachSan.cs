using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class KhachSan : BatDS, IPhiKD
    {
        int sosao;

        public int Sosao
        {
            get { return sosao; }
            set { sosao = value; }
        }
        public KhachSan()
            : base()
        {
            Sosao = 0;
        }
        public KhachSan(string ma, double cd, double cr, int sosao)
            : base(ma, cd, cr)
        {
            Sosao = sosao;
        }
        public override double GiaBan()
        {
            return sosao * 50000 + 100000;
        }
        public double IChiPhi()
        {
            return Cr * 5000;
        }
        public override void Xuat()
        {
            Console.WriteLine("-----KHACHSAN");
            base.Xuat();
            Console.WriteLine("Chi Phi: {0}",IChiPhi());
        }

    }
}

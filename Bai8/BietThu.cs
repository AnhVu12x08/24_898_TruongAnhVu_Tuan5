using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class BietThu: BatDS, IPhiKD
    {
        public BietThu() : base() { }
        public BietThu(string ma,double dai,double rong)
            : base(ma, dai, rong)
        {
        }
        public override double GiaBan()
        {
            return DienTich() * 400000;
        }
        public double IChiPhi()
        {
            return DienTich() * 1000;
        }
        public override void Xuat()
        {
            Console.WriteLine("-----BIETTHU");
            base.Xuat();
            Console.WriteLine("Chi Phi: {0}", IChiPhi());
        }
    }
}

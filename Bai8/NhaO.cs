using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class NhaO : BatDS
    {
        int solau;

        public int Solau
        {
            get { return solau; }
            set { solau = value; }
        }
        public NhaO() : base() { }
        public NhaO(string ma, double cd, double cr, int solau)
            : base(ma, cd, cr)
        {
            Solau = solau;
        }
        public override double GiaBan()
        {
            return DienTich() * 10000 + solau * 10000;
        }
        public override void Xuat()
        {
            Console.WriteLine("-----NHAO");
            base.Xuat();
        }


    }
}

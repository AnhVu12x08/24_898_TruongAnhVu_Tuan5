using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class DatTrong :BatDS
    {
        public DatTrong() :base()
        {
        }
        public DatTrong(string ma,double dai,double rong)
            : base(ma, dai, rong)
        {
        }
        public override double GiaBan()
        {
            return DienTich() * 10000;
        }
        public override void Xuat()
        {
            Console.WriteLine("-----DATTRONG");
            base.Xuat();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.InputEncoding = UnicodeEncoding.Unicode;

            DSBatDS ds = new DSBatDS();
            ds.DocXml(@"..\..\DSBatDS.xml");
            ds.XuatXML();
            Console.ReadKey();

        }
    }
}

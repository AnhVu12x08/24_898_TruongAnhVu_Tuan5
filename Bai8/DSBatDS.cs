using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai8
{
    class DSBatDS
    {
        List<BatDS> ds;
        
        public List<BatDS> Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        public DSBatDS()   
        {
            ds = new List<BatDS>();
        }

        public void DocXml(string filepath)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filepath);

            XmlNodeList nodelist = read.SelectNodes("/BDSs/BDS");
            foreach (XmlNode node in nodelist)
            {
                BatDS bds;
                string ma = node["Ma"].InnerText;
                int dai = int.Parse(node["Dai"].InnerText);
                int rong = int.Parse(node["Rong"].InnerText);

                int loai = int.Parse(node["Loai"].InnerText);
                if (loai == 1)
                {
                    bds = new DatTrong(ma, dai, rong);
                }
                else if (loai == 4)
                {
                    bds = new BietThu(ma, dai, rong);
                }
                else if (loai == 2)
                {
                    int sl = int.Parse(node["Solau"].InnerText);
                    bds = new NhaO(ma, dai, rong, sl);
                }
                else
                {
                    int ss = int.Parse(node["Sosao"].InnerText);
                    bds = new KhachSan(ma, dai, rong, ss);
                }
                ds.Add(bds);
            }
        }
        public void XuatXML()
        {
            foreach (BatDS nv in ds)
            {
                nv.Xuat();
            }
        }

    }
}

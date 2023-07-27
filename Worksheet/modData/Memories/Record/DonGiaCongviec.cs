using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Record
{
    internal class DonGiaCongViec : ARecord
    {
        public int DGId;
        public DonGiaCongViec(int dgId)
        {
            DGId = dgId;
        }

        public override string Path { get { return "DonGia." + DGId + ".Congviec." + Id; } }
        public void setDefault()
        {
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = ""; 

            ColNum["dinhmuc"] = 0;
            ColNum["giagoc"] = 0;
            ColNum["gia"] = 0; 
        }
    }
}
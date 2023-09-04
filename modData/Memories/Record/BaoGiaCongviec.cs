using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Memories.Record
{
    internal class BaoGiaCongviec : ARecord
    {
        public int BGId;
        public BaoGiaCongviec(int bgId)
        {
            BGId = bgId;
        }

        public override string Path { get { return "BaoGia." + BGId + ".Congviec." + Id; } }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Memories.Record
{
    internal class BaoGiaCaMay : ARecord
    {
        public int BGId;
        public BaoGiaCaMay(int bgId)
        {
            BGId = bgId;
        }

        public override string Path { get { return "BaoGia." + BGId + ".CaMay." + Id; } }


        protected void init()
        {
            ColText["stt"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";

            ColNum["haophi"] = 0;
            ColNum["giagoc"] = 0;
            ColNum["gia"] = 0;
            ColNum["haophikhac"] = 0;
        }

    }
}
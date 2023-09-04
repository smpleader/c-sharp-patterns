using modData.Memories.Pointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Memories.Record
{
    internal class HangMuc : ARecord
    {
        public HangMuc(string ten, string kieu)
        {
            ColText["ten"] = ten;
            ColText["kieuhangmuc"] = kieu;

            Id = Current.HM.id(true);
        }

        public override string Path { get { return "HangMuc." + Id; } }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Memories.Record
{
    internal class BaoGia : ARecord
    {
        public BaoGia(string ten, string ma) 
        {
            ColText["ten"] = ten;
            ColText["ma"] = ma;

            Id = Current.HM.id(true);
        }
         
        public override string Path { get { return "BaoGia." + Id; } }
    }
}
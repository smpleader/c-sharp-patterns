using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row.DonGia
{
    internal class Congviec : ARow
    {
        public Congviec() : base() { }
        public void init()
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
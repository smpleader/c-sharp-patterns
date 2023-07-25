using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Row;
using Worksheet.modDisplay.Tpl.report1;

namespace Worksheet.modDisplay.Tpl.vatlieu
{
    internal class Row: VatLieu
    { 
        string A { get { return txt("stt"); } set { txt("stt", value); } }
        string B { get { return txt("ma"); } set { txt("ma", value); } }
        string C { get { return txt("ten"); } set { txt("ten", value); } }
        string D { get { return txt("donvi"); } set { txt("donvi", value); } }
        string I { get { return txt("loai"); } set { txt("loai", value); } }
        decimal E { get { return num("haophi"); } set { num("haophi", value); } }
        decimal F { get { return num("giagoc"); } set { num("giagoc", value); } }
        decimal G { get { return num("giatb"); } set { num("giatb", value); } }
        decimal H { get { return num("giaht"); } set { num("giaht", value); } }
        decimal K { get { return num("haophikhac"); } set { num("haophikhac", value); } }
    }
}

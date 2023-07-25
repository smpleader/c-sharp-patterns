using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    // level 5
    internal class NhanCong:CongViec
    {
        public NhanCong() : base() { }
        public bool filterType(ARow r) { return r.Path.Contains(CVid()+".NhanCong.") && r.Path.isLevel5(); }
        public bool filterItem(ARow r) { return r.Path.Contains(NCid()) && r.Path.isLevel5(); }
        public bool filterFamily(ARow r) { return r.Path.Contains(NCid()); }
        public string NCid()
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + Current.CV.id() + ".NhanCong." + Current.NC.id();
        }
    }
}

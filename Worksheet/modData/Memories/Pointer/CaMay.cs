using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    // level 5
    internal class CaMay:CongViec
    {
        public CaMay() : base() { }
        public bool filterType(ARow r) { return r.Path.Contains(CVid()+ ".CaMay.") && r.Path.isLevel5(); }
        public bool filterItem(ARow r) { return r.Path.Contains(CMid()) && r.Path.isLevel5(); }
        public bool filterFamily(ARow r) { return r.Path.Contains(CMid()); }
        public string CMid()
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + Current.CV.id() + ".CaMay." + Current.CM.id();
        }
    }
}

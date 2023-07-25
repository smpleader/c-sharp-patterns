using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    // level 3
    internal class CongViec:HangMuc
    {
        public CongViec():base(){ }
        public bool filterType(ARow r) { return r.Path.Contains(HMid()) && r.Path.isLevel3(); }
        public bool filterItem(ARow r) { return r.Path.Contains(CVid()) && r.Path.isLevel3(); }
        public bool filterFamily(ARow r) { return r.Path.Contains(CVid()); }
        public string CVid()
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + Current.CV.id();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    // level 1
    internal class HangMuc:Base
    {
        public HangMuc():base() { } 
        // reflect to domainize the context
        public bool filterType(ARow r) { return r.Path.Contains("HangMuc.") && r.Path.isLevel1(); }
        public bool filterItem(ARow r) { return r.Path.Contains(HMid()) && r.Path.isLevel1(); }
        public bool filterFamily(ARow r) { return r.Path.Contains(HMid()); }
        public string HMid()
        {
            return "HangMuc." + Current.HM.id();
        }
    }
}

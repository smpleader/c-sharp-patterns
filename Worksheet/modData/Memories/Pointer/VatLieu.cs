using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    // level 5
    internal class VatLieu:CongViec
    {
        public VatLieu() : base() { }
        public bool filterType(ARow r) { return r.Path.Contains(CVid()+".VatLieu.") && r.Path.isLevel5(); }
        public bool filterItem(ARow r) { return r.Path.Contains(VLid()) && r.Path.isLevel5(); }
        public bool filterFamily(ARow r) { return r.Path.Contains(VLid()); }
        public string VLid()
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + Current.CV.id() + ".VatLieu." + Current.VL.id();
        }
    }
}

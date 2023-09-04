using modData;
using modData.Memories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CMrecord = modData.Memories.Record.CaMay;

namespace modData.Memories.Pointer
{
    // level 5
    internal class CaMay : Base
    {
        public override bool filterType(ARecord r) { return r.Path.Contains(".CaMay.") && r.Path.isLevel5(); }
        public override bool filterSibling(ARecord r) { return r.Path.Contains(Current.CV.path() + ".CaMay.") && r.Path.isLevel5(); }
        public override bool filterItem(ARecord r) { return r.Path == path(); }
        public override bool filterFamily(ARecord r) { return r.Path.Contains(path()); }
        public override string path(int id = -1)
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + Current.CV.id() + ".CaMay." + (-1 == id ? Id : id);
        }

        public CMrecord? load(int id = -1)
        {
            ARecord? row = memories.Storage.Find(r => r.Path == path(id));
            return null == row ? null : (CMrecord)row;
        }
    }
}

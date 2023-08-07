using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CVrecord = Worksheet.modData.Memories.Record.CongViec;

namespace Worksheet.modData.Memories.Pointer
{
    // level 3
    internal class CongViec:Base
    {
        public override bool filterType(ARecord r) { return r.Path.Contains(".CongViec.") && r.Path.isLevel3(); }
        public override bool filterSibling(ARecord r) { return r.Path.Contains(Current.HM.path() + ".CongViec.") && r.Path.isLevel3(); }
        public override bool filterItem(ARecord r) { return r.Path == path(); }
        public override bool filterFamily(ARecord r) { return r.Path.Contains(path()); }
        public override string path(int id = -1)
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + (-1 == id ? Id : id);
        }
        public CVrecord? load(int id = -1)
        {
            ARecord? row = memories.Storage.Find(r => r.Path == path(id));
            return null == row ? null : (CVrecord)row;
        }
    }
}

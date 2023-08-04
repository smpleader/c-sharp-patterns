using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VLrecord = Worksheet.modData.Memories.Record.VatLieu;

namespace Worksheet.modData.Memories.Pointer
{
    // level 5
    internal class VatLieu:Base
    {
        public override bool filterType(ARecord r) { return r.Path.Contains(".VatLieu.") && r.Path.isLevel5(); }
        public override bool filterSibling(ARecord r) { return r.Path.Contains(Current.CV.path() + ".VatLieu.") && r.Path.isLevel5(); }
        public override bool filterItem(ARecord r) { return r.Path == path(); }
        public override bool filterFamily(ARecord r) { return r.Path.Contains(path()); }
        public override string path(int id = -1)
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + Current.CV.id() + ".VatLieu." + (-1 == id ? Id : id);
        }

        public VLrecord? load(int id = -1)
        {
            ARecord? row = DB.Storage.Find(r => r.Path == path(id));
            return null == row ? null : (VLrecord)row;
        }
    }
}

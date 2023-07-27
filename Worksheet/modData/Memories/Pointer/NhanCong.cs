using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NCrecord = Worksheet.modData.Memories.Record.NhanCong;

namespace Worksheet.modData.Memories.Pointer
{
    // level 5
    internal class NhanCong:Base
    {
        public override bool filterType(ARecord r) { return r.Path.Contains(".NhanCong.") && r.Path.isLevel5(); }
        public override bool filterSibling(ARecord r) { return r.Path.Contains(Current.CV.path() + ".NhanCong.") && r.Path.isLevel5(); }
        public override bool filterItem(ARecord r) { return r.Path == path(); }
        public override bool filterFamily(ARecord r) { return r.Path.Contains(path()); }
        public override string path(int id = -1)
        {
            return "HangMuc." + Current.HM.id() + ".CongViec." + Current.CV.id() + ".NhanCong." + ( -1 == id ? Id : id);
        }

        public NCrecord? load(int id = -1)
        {
            ARecord? row = Storage.R.Find(r => r.Path == path(id));
            return null == row ? null : (NCrecord)row;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HMreord = Worksheet.modData.Memories.Record.HangMuc;

namespace Worksheet.modData.Memories.Pointer
{
    // level 1
    internal class HangMuc:Base
    {
        // reflect to domainize the context
        public override bool filterType(ARecord r) { return r.Path.Contains("HangMuc.") && r.Path.isLevel1(); }
        public override bool filterSibling(ARecord r) { return filterType(r);}
        public override bool filterItem(ARecord r) { return r.Path == path(); }
        public override bool filterFamily(ARecord r) { return r.Path.Contains(path()); }
        public override string path(int id = -1)
        {
            return "HangMuc." + (-1 == id ? Id : id);
        }
        public HMreord? load(int id = -1)
        {
            ARecord? row = DB.Storage.Find(r => r.Path == path(id));
            return null == row ? null : (HMreord)row;
        }
    }
}

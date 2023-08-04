using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    // level 1
    internal class Other:Base
    {
        public string Name { get; }

        public Other(string name) { Name = name; }

        public string path(int id = -1) { return Name + "." + (-1 == id ? Id : id); }

        public override bool filterType(ARecord r) { return r.Path.Contains(Name+".") && r.Path.isLevel1(); }
        public override bool filterSibling(ARecord r) { return filterType(r);}
        public override bool filterItem(ARecord r) { return r.Path == path(); }
        public override bool filterFamily(ARecord r) { return r.Path.Contains(Name + "."); }
        public ARecord load(int id = -1)
        {
            return DB.Storage.Find(r => r.Path == path(id));
        }
    }
}

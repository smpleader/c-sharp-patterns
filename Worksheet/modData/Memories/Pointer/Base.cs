using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    internal class Base
    {
        protected int Id = -1; 
        public int id(bool nextId = false) {
            if(Id == -1)
            {
                List<ARecord> rows = Storage.R.FindAll(filterType);
                Id = rows.Count > 0 ? rows.Last().Id : 0;
            }
            return nextId ? Id+1 : Id; 
        }
        public void id(int ID) { Id = ID; }
        public virtual string path(int id) { return ""; }

        // items has same type
        public virtual bool filterType(ARecord r) { return true; }

        // items has same type in same parent
        public virtual bool filterSibling(ARecord r) { return true; }
        // item with its children
        public virtual bool filterFamily(ARecord r) { return true; }
        // only item 
        public virtual bool filterItem(ARecord r) { return true; }
    }
}

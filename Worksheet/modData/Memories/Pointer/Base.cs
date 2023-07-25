using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    internal class Base
    {
        public Base()
        {
            List<ARow> rows = Storage.R.FindAll(filterType);
            if (rows.Count > 0)
            {
                Id = rows.Last().Id;
            }
        }

        protected int Id = 0; 
        public int id() { return Id; }
        public void id(int ID) { Id = ID; }

        // items has same type
        public bool filterType(ARow r) { return true; }
        // item with its children
        public bool filterFamily(ARow r) { return true; }
        // only item 
        public bool filterItem(ARow r) { return true; }
    }
}

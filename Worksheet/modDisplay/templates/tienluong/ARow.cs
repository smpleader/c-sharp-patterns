using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class ARow : ARowObject
    {
        public ARow(int id)
        {
            Id = id;
        }
        public virtual string Address(string col)
        {
            return col + Id;
        }
        public virtual string GetFormula(string col)
        {
            return "";
        }

    }
}

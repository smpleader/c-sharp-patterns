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
        public virtual int HMId { get; }

        public ARow(int id)
        {
            Id = id;
            HMId = Current.HM.id();
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL
{
    internal class ACell : ICell
    {
        public ACell(Option opt) 
        {
            Option = opt;
        }
        public virtual string Name => "Default";

        public virtual string Col => "A";

        public Option Option { get ; set ; }

        public virtual string formula(string[] args)
        {
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL
{
    internal class ACell : ICell
    {
        public ACell(Option opt)
        {
            Option = opt;
        }

        // Col name
        public virtual string CName => "A";

        // Unique name
        public virtual string UName => "Default";

        public Option Option { get; set; }

        public virtual string formula(string[] args)
        {
            return "";
        }
    }
}

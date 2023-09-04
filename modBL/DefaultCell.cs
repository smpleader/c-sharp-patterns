using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL
{
    internal class DefaultCell : ACell
    {
        public DefaultCell(Option opt) : base(opt)
        {
        }
        public override string CName => "A";
        public override string UName => "Default";
        public override string formula(string[] args)
        {
            return "";
        }
    }
}

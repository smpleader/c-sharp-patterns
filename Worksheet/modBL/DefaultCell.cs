using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL
{
    internal class DefaultCell : ACell
    {
        public DefaultCell(Option opt) : base(opt)
        {
        }
        public override string Col => "A";
        public override string Name => "Default";
        public override string formula(string[] args)
        {
            return "";
        }
    }
}

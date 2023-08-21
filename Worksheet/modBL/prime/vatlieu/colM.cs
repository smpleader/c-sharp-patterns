using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }

        public override string Col => "M";
        public override string Name => "VatLieu_CuocOto";
        public override string formula(string[] args)
        {
            return "Cước ô tô.CuocOto_TongCuoc";
        }
    }
}

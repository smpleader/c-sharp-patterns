using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colV : ACell
    {
        public colV(Option opt) : base(opt)
        {
        }

        public override string Col => "V";
        public override string Name => "VatLieu_GiaHienTruong";
        public override string formula(string[] args)
        {
            return $"=J{args[0]}+U{args[0]}";
        }
    }
}

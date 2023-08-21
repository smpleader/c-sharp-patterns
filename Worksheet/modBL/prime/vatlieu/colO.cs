using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string Col => "O";
        public override string Name => "VatLieu_CuocSong";
        public override string formula(string[] args)
        {
            return "Cước sông.CuocSong_TongCuoc";
        }
    }
}

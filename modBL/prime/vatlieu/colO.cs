using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "VatLieu_CuocSong";
        public override string formula(string[] args)
        {
            switch (Option.PPTCuocSong)
            {
                case PPTCuocSong.MauChung:
                    return $"='Cước sông'!P{args[0]}";
                    // todo: thêm các trường hợp cho các ppt khác

            }
            return base.formula(args);
        }
    }
}

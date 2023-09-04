using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "VatLieu_CuocSong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng tổng cước trong bảng cước sông </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTCuocSong)
            {
                case PPTCuocSong.MauChung:
                case PPTCuocSong.MauCaMau:
                    return "";
                case PPTCuocSong.MauDongThap:
                    return $"='Cước sông'!P{args[0]}";
            }
            return base.formula(args);
        }
    }
}

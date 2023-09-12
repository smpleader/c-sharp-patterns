using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colZ : ACell
    {
        public colZ(Option opt) : base(opt)
        {
        }
        public override string CName => "Z";
        public override string UName => "CuocOto_QuangBinh_GiaVatLieuBinhQuanDenChanCongTrinh";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=J{args[0]}*Y{args[0]}";
        }
    }
}

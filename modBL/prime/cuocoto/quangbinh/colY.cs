using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colY : ACell
    {
        public colY(Option opt) : base(opt)
        {
        }
        public override string CName => "Y";
        public override string UName => "CuocOto_QuangBinh_GiaVatLieuDenChanCongTrinh";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}+S{args[0]}+X{args[0]}";
        }
    }
}

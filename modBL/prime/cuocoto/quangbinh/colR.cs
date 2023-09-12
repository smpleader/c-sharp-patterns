using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colR : ACell
    {
        public colR(Option opt) : base(opt)
        {
        }
        public override string CName => "R";
        public override string UName => "CuocOto_QuangBinh_ThanhTienChiPhiVanChuyen";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu tính cước</para>
        /// <para> Tham số 2 là chỉ số dòng hiện tại tính cước (bổ sung dòng cước)</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}*G{args[0]}*L{args[1]}*N{args[1]}*P{args[1]}/(1+D5)+Q{args[1]}";
        }
    }
}

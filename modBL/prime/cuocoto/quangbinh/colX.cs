using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colX : ACell
    {
        public colX(Option opt) : base(opt)
        {
        }
        public override string CName => "X";
        public override string UName => "CuocOto_QuangBinh_CongChiPhiTrungChuyen";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=U{args[0]}+W{args[0]}"; // Cột U: thành tiền bốc xếp chi phí trung chuyển, cột W: thành tiền hao hụt trung chuyển
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=U{args[0]}+W{args[0]}"; // Cột U: thành tiền bốc xếp chi phí trung chuyển, cột W: thành tiền hao hụt trung chuyển
        }
    }
}

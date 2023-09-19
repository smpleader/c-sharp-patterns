using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.caobangthem
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }
        public override string CName => "S";
        public override string UName => "CuocOto_CaoBangThem_ThanhTienChiPhiBocDo";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu tính cước</para>
        /// <para> Tham số 2 là chỉ số dòng hiện tại tính cước (bổ sung dòng cước)</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=IF(E{args[0]}*M{args[1]}=0;0;W4*R{args[1]})"; // Cột E: khối lượng đơn vị, cột M: cự ly, cột W: lương nhân công bốc dỡ, cột R: định mức chi phí bốc dỡ
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=IF(E{args[0]}*M{args[1]}=0;0;W4*R{args[1]})"; // Cột E: khối lượng đơn vị, cột M: cự ly, cột W: lương nhân công bốc dỡ, cột R: định mức chi phí bốc dỡ
        }
    }
}

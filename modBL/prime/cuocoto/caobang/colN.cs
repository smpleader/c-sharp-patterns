using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.caobang
{
    public class colN : ACell
    {
        public colN(Option opt) : base(opt)
        {
        }
        public override string CName => "N";
        public override string UName => "CuocOto_CaoBang_TongCuLy";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(M{args[0]}:M{args[1]})"; // Cột M: cự ly
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(M{args[0]}:M{args[1]})"; // Cột M: cự ly
        }
    }
}

using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocsong.mauchung
{
    public class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "CuocSong_MauChung_TongCuLy";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước cho một vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước cho một vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(K{args[0]}:K{args[1]})"; // cột K: cự ly quy đổi
        }
    }
}

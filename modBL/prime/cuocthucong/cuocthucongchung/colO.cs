using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.cuocthucongchung
{
    public class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "CuocTC_MauChung_TongCuoc";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //H8*SUM(M8:M10)+SUM(N8:N10)
            return $"=H{args[0]}*SUM(M{args[0]}:M{args[1]})+SUM(N{args[0]}:N{args[1]})";
        }
    }
}

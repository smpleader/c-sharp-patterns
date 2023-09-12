using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.cuocthucongchung
{
    // Tính giá cước bốc dỡ
    internal class colMBocDo : ACell
    {
        public colMBocDo(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "CuocTC_MauChung_GiaCuocBocDo";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là định mức theo nhóm hàng (cột thứ 3). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //K10*10615
            return $"=K{args[0]}*{args[1]}";
        }
    }
}

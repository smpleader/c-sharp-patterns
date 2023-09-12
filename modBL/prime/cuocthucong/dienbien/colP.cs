using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.dienbien
{
    internal class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }

        public override string CName => "P";
        public override string UName => "CuocTC_DienBien_DinhMucBocDo";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là định mức theo nhóm hàng (cột thứ 3). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //IF(O10<=0;0;0,12)
            return $"=IF(O{args[0]}<=0;0;{args[1]})";
        }
    }
}

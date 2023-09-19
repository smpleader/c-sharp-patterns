using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.dienbien
{
    public class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }

        public override string CName => "Q";
        public override string UName => "CuocTC_DienBien_DinhMucVanChuyen";

        /// <summary>
        /// 5 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là định mức theo nhóm hàng (cột thứ 4). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// <para> Tham số 3 là định mức theo nhóm hàng (cột thứ 5). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// <para> Tham số 4 là định mức theo nhóm hàng (cột thứ 6). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// <para> Tham số 5 là định mức theo nhóm hàng (cột thứ 7). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //IF(O10<=0;0;IF(O10<=0,1;3,9;IF(O10<=0,3;3,74;IF(O10<=0,5;3,69;3,66))))
            return $"=IF(O{args[0]}<=0;0;IF(O{args[0]}<=0,1;{args[1]};IF(O{args[0]}<=0,3;{args[2]};IF(O{args[0]}<=0,5;{args[3]};{args[4]}))))";
        }
    }
}

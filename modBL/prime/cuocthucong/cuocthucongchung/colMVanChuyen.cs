using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.cuocthucongchung
{
    // Tính giá cước vận chuyển
    public class colMVanChuyen : ACell
    {
        public colMVanChuyen(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "CuocTC_MauChung_GiaCuocVanChuyen";

        /// <summary>
        /// 4 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là định mức theo nhóm hàng (cột thứ 4). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// <para> Tham số 3 là định mức theo nhóm hàng (cột thứ 5). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// <para> Tham số 4 là định mức theo nhóm hàng (cột thứ 6). Giá trị nằm trong file biểu cước (phần giá cước)</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //K10*IF(L10<=0;0;IF(L10<=50;8154;IF(L10<=200;10462;15077)))
            return $"=K{args[0]}*IF(L{args[0]}<=0;0;IF(L{args[0]}<=50;{args[1]};IF(L{args[0]}<=200;{args[2]};{args[3]})))";
        }
    }
}

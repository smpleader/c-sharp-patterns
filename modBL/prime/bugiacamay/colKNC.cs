using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Chênh lệch giá hiện trường nhân công
    public class colKNC : ACell
    {
        public colKNC(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "BuGiaCM_ChenhLechGiaHienTruongNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=J{args[0]}-H{args[0]}";
        }
    }
}

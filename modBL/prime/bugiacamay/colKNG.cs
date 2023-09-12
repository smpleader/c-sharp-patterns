using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Chênh lệch giá hiện trường nguyên giá
    public class colKNG : ACell
    {
        public colKNG(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "BuGiaCM_ChenhLechGiaHienTruongNguyenGia";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nguyên giá</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=J{args[0]}-H{args[0]}";
        }
    }
}

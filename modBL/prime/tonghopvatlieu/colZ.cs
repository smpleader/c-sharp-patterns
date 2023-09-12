using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Tính thành tiền chênh lệch giá HT cho một vật liệu
    internal class colZ : ACell
    {
        public colZ(Option opt) : base(opt)
        {
        }

        public override string CName => "Z";
        public override string UName => "THVL_ThanhTienChenhLechGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền giá HT trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*Y{args[0]}";
        }
    }
}

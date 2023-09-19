using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colW : ACell
    {
        public colW(Option opt) : base(opt)
        {
        }
        public override string CName => "W";
        public override string UName => "CuocOto_QuangBinh_ThanhTienHaoHutTrungChuyenTrungChuyen";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(I{args[0]}+S{args[0]})*V{args[0]}"; // Cột I: giá mua, cột S: tổng CP vận chuyển, cột V: định mức hao hụt trung chuyển
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=(I{args[0]}+S{args[0]})*V{args[0]}"; // Cột I: giá mua, cột S: tổng CP vận chuyển, cột V: định mức hao hụt trung chuyển
        }
    }
}

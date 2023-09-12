using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tinhgiacamay
{
    // Tính thành tiền một nhiên liệu
    public class colINL : ACell
    {
        public colINL(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TinhGiaCM_ThanhTienTinhGiaNhienLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số dòng nhiên liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}*F{args[0]}*H{args[0]}";
        }
    }
}

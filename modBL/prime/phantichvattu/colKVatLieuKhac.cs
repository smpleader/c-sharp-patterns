using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá TB vật liệu khác
    /// </summary>
    public class colKVatLieuKhac : ACell
    {
        public colKVatLieuKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "PTVT_GiaThongBaoVatLieuKhac";

        // <summary>
        /// n tham số
        /// <para> số lượng dòng vật liệu theo công việc trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            var tmp = $"=(";
            for (var i = 0; i < args.Length; i++)
            {
                tmp += $"F{args[i]}*K{args[i]}+"; // Cột F: Định mức vật liệu, cột I: Đơn giá TB vật liệu
            }
            var formula = tmp.TrimEnd('+');
            formula += ")/100";
            return formula;
        }
    }
}

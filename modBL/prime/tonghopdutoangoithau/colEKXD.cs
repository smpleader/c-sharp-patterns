using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Thuế GTGT chi phí công tác không xác định
    /// </summary>
    public class colEKXD : ACell
    {
        public colEKXD(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_ThueGiaTriGiaTangChiPhiKhongXacDinh";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chí phí công tác không xác định</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*10%"; //Cột D: Giá trị trước thuế chi phí công tác không xác định
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*10%"; //Cột D: Giá trị trước thuế chi phí công tác không xác định
        }
    }
}

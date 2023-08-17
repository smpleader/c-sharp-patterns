using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Footer : ARow
    {
        public Footer(int id) : base(id)
        {
            Id = id;
        }
        /// <summary>
        /// Địa chỉ ô cho phép lấy B
        /// </summary>
        /// <param name="col"></param>
        /// <returns> col + indexRow</returns>
        //public string Address(string col)
        //{
        //    return col + Id;
        //}
        /// <summary>
        /// Lấy công thức cho các cột  R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public override string GetFormula(string col)
        {
            string uniqueName = "";
            string formula;
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            switch (col)
            {
                case "R":
                    uniqueName = "CongViec_ThanhTienVatLieu";
                    break;
                case "S":
                    uniqueName = "CongViec_ThanhTienVatLieuPhu";
                    break;
                case "T":
                    uniqueName = "CongViec_ThanhTienNhanCong";
                    break;
                case "U":
                    uniqueName = "CongViec_ThanhTienMay";
                    break;
                default: break;
            }
            formula = string.Format(modBL.Container.Get(uniqueName).fml(parameters));
            return formula;
        }
        public void bind(unvell.ReoGrid.Worksheet worksheet)
        {
            List<string> colsHaveFormula = new List<string>() { "R", "S", "T", "U" };
            foreach (string col in colsHaveFormula)
            {
                worksheet[Address(col)] = GetFormula(col);
            }
        }
        public void render(unvell.ReoGrid.Worksheet worksheet)
        {
            // todo: render khi thêm hoặc xóa dòng
        }
    }
}

using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.IO.OpenXML.Schema;
using unvell.ReoGrid.Utility;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Row : ARow
    {

        public Row(int id) : base(id)
        {
            Id = id;
        }
        public bool HaveInterpretiveFormula = false;

        /// <summary>
        /// Địa chỉ ô cho phép lấy A, B, C, D, E, N, O, P, Q, R, S, T, U, V, W, X, Y, Z, AA, AB, AC
        /// </summary>
        /// <param name="col"></param>
        /// <returns> col + indexRow</returns>
        //public string Address(string col)
        //{
        //    return col + Id;
        //}

        /// <summary>
        /// Lấy công thức cho các cột M, N, O, P,
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public override string GetFormula(string col)
        {
            string uniqueName = "";
            string formula;
            string[] parameters = new string[1] { Id.ToString() };
            switch (col)
            {
                case "M":
                    if (HaveInterpretiveFormula)
                    {
                        uniqueName = "CongViec_KhoiLuong";
                        parameters = new string[2] { (start + 1).ToString(), end.ToString() };
                        break;
                    }
                    else
                    {
                        return CellUtility.ConvertData<string>(((Generator)Display.tab("Tiên lượng")).ws[Address("M")]);
                    }
                case "N":
                    uniqueName = "CongViec_DonGiaVatLieu";
                    decimal tongGiaVatLieu = CellUtility.ConvertData<decimal>(((Generator)Display.tab("Tiên lượng")).ws[Address("Z")]);
                    parameters = new string[2] { Id.ToString(), tongGiaVatLieu.ToString() };
                    break;
                case "O":
                    uniqueName = "CongViec_DonGiaVatLieuPhu";
                    decimal tongGiaVatLieuPhu = CellUtility.ConvertData<decimal>(((Generator)Display.tab("Tiên lượng")).ws[Address("AA")]);
                    parameters = new string[2] { Id.ToString(), tongGiaVatLieuPhu.ToString() };
                    break;
                case "P":
                    uniqueName = "CongViec_DonGiaNhanCong";
                    decimal tongGiaNhanCong = CellUtility.ConvertData<decimal>(((Generator)Display.tab("Tiên lượng")).ws[Address("AB")]);
                    parameters = new string[2] { Id.ToString(), tongGiaNhanCong.ToString() };
                    break;
                case "Q":
                    uniqueName = "CongViec_DonGiaMay";
                    decimal tongGiaMay = CellUtility.ConvertData<decimal>(((Generator)Display.tab("Tiên lượng")).ws[Address("AC")]);
                    parameters = new string[2] { Id.ToString(), tongGiaMay.ToString() };
                    break;
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
                default:  break;
            }
            formula = string.Format(modBL.Container.Get(uniqueName).fml(parameters));
            return formula;
        }

        public void bind(unvell.ReoGrid.Worksheet worksheet)
        {
            List<string> colsHaveFormula = new List<string>() { "M", "N", "O", "P", "Q", "R", "S", "T", "U" };
            foreach(string col in colsHaveFormula)
            {
                worksheet[Address(col)] = GetFormula(col);
            }
        }
    }
}

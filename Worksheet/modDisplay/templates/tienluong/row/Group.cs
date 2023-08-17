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

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal class Group : ARow
    {
        public Group(int id) : base(id)
        {
            Id = id;
        }

        /// <summary>
        /// Địa chỉ ô cho phép lấy A, B, C, Q, X, R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns> col + indexRow</returns>
        //public string Address(string col)
        //{
        //    return col + Id;
        //}

        /// <summary>
        /// Lấy công thức cho các cột R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public override string GetFormula(string col)
        {
            string uniqueName = "";
            switch (col)
            {
                case "R":
                    uniqueName = "NhomCongViec_ThanhTienVatLieu";
                    break;
                case "S":
                    uniqueName = "NhomCongViec_ThanhTienVatLieuPhu";
                    break;
                case "T":
                    uniqueName = "NhomCongViec_ThanhTienNhanCong";
                    break;
                case "U":
                    uniqueName = "NhomCongViec_ThanhTienMay";
                    break;
                default: return uniqueName;
            }
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            return string.Format(modBL.Container.Get(uniqueName).fml(parameters));
        }

        public void bind(unvell.ReoGrid.Worksheet worksheet)
        {
            // check group object khi mở từ file excel ( bind)
            string addressColB = Address("B");

            // check group object khi nhập vào
            string addressColA = Address("A");
            string addressColC = Address("C");
            string addressColQ = Address("Q");
            string addressColX = Address("X");

            string C = CellUtility.ConvertData<string>(worksheet[addressColC]);
            if (C != null && C.StartsWith("*"))
            {
                string nameGroup = C.Substring(1);
                if (nameGroup.Length == 0)
                {
                    nameGroup = "(Nhóm không tên)";
                }
                worksheet.MergeRange(addressColB + ":" + addressColQ);
                worksheet[addressColB] = nameGroup;

                #region style lại cho group object

                worksheet.SetRangeStyles(addressColB, new WorksheetRangeStyle
                {
                    Flag = PlainStyleFlag.AlignAll,
                    HAlign = ReoGridHorAlign.Left,
                });

                string rangeGroup = addressColA + ":" + addressColX;

                worksheet.SetRangeStyles(rangeGroup, new WorksheetRangeStyle
                {
                    // style item flag
                    Flag = PlainStyleFlag.BackColor,
                    // style item
                    BackColor = Color.FromArgb(213, 247, 183),
                });

                var blackDottedBoder = new RangeBorderStyle
                {
                    Color = Color.Black,
                    Style = BorderLineStyle.Dotted,
                };
                worksheet.SetRangeBorders(rangeGroup, BorderPositions.InsideHorizontal, blackDottedBoder);

                var blackSolidBoder = new RangeBorderStyle
                {
                    Color = Color.Black,
                    Style = BorderLineStyle.Solid,
                };
                worksheet.SetRangeBorders(rangeGroup, BorderPositions.Left, blackSolidBoder);
                worksheet.SetRangeBorders(rangeGroup, BorderPositions.Right, blackSolidBoder);
                worksheet.SetRangeBorders(rangeGroup, BorderPositions.InsideVertical, blackSolidBoder);
                worksheet.SetRangeBorders(rangeGroup, BorderPositions.Outside, blackSolidBoder);

                #endregion
            }

            //List<string> colsHaveFormula = new List<string>() { "R", "S", "T", "U" };
            //foreach (string col in colsHaveFormula)
            //{
            //    worksheet[Address(col)] = GetFormula(col);
            //}
        }

        public void render(unvell.ReoGrid.Worksheet worksheet)
        {
            List<string> colsHaveFormula = new List<string>() { "R", "S", "T", "U" };
            foreach (string col in colsHaveFormula)
            {
                worksheet[Address(col)] = GetFormula(col);
            }
        }
    }
}

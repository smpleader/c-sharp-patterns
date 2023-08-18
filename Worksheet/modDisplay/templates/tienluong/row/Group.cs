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
using Cell = unvell.ReoGrid.Cell;

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal class Group : ARowObject
    {
        public Group(unvell.ReoGrid.Worksheet worksheet, int id)
        {
            ws = worksheet;
            Id = id;
        }

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public Cell A { get { return GetCell("A"); } }
        /// <summary>
        /// STT
        /// </summary>
        public Cell B { get { return GetCell("B"); } }
        /// <summary>
        /// MSCV
        /// </summary>
        public Cell C { get { return GetCell("C"); } }
        /// <summary>
        /// Đơn giá máy
        /// </summary>
        public Cell Q { get { return GetCell("Q"); } }
        /// <summary>
        /// Tổng thành tiền vật liệu của nhóm
        /// </summary>
        public Cell R { get { return GetCell("R"); } }
        /// Tổng thành tiền vật liệu phụ của nhóm
        public Cell S { get { return GetCell("S"); } }
        /// <summary>
        /// Tổng thành tiền nhân công của nhóm
        /// </summary>
        public Cell T { get { return GetCell("T"); } }
        /// <summary>
        /// Tổng thành tiền máy của nhóm
        /// </summary>
        public Cell U { get { return GetCell("U"); } }
        /// <summary>
        /// Hệ số điều chỉnh máy
        /// </summary>
        public Cell X { get { return GetCell("X"); } }
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

        public void bind()
        {
            // check group object khi mở từ file excel ( bind)

            string C = this.C.GetData<string>();
            if (C != null && C.StartsWith("*"))
            {
                string nameGroup = C.Substring(1);
                if (nameGroup.Length == 0)
                {
                    nameGroup = "(Nhóm không tên)";
                }
                ws.MergeRange(B.Position.ToAddress() + ":" + Q.Position.ToAddress());
                B.Data = nameGroup;

                #region style lại cho group object

                ws.SetRangeStyles(B.Position.ToAddress(), new WorksheetRangeStyle
                {
                    Flag = PlainStyleFlag.AlignAll,
                    HAlign = ReoGridHorAlign.Left,
                });

                string rangeGroup = A.Position.ToAddress() + ":" + X.Position.ToAddress();

                ws.SetRangeStyles(rangeGroup, new WorksheetRangeStyle
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
                ws.SetRangeBorders(rangeGroup, BorderPositions.InsideHorizontal, blackDottedBoder);

                var blackSolidBoder = new RangeBorderStyle
                {
                    Color = Color.Black,
                    Style = BorderLineStyle.Solid,
                };
                ws.SetRangeBorders(rangeGroup, BorderPositions.Left, blackSolidBoder);
                ws.SetRangeBorders(rangeGroup, BorderPositions.Right, blackSolidBoder);
                ws.SetRangeBorders(rangeGroup, BorderPositions.InsideVertical, blackSolidBoder);
                ws.SetRangeBorders(rangeGroup, BorderPositions.Outside, blackSolidBoder);

                #endregion
            }
        }

        public void render()
        {
            List<string> colsHaveFormula = new List<string>() { "R", "S", "T", "U" };
            foreach (string col in colsHaveFormula)
            {
                ws[col + Id] = GetFormula(col);
            }
        }
    }
}

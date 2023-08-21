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
        Dictionary<string, string> aliasUniqueName = new Dictionary<string, string>() {
            { "R", "NhomCongViec_ThanhTienVatLieu" },
            { "S", "NhomCongViec_ThanhTienVatLieuPhu" },
            { "T", "NhomCongViec_ThanhTienNhanCong" },
            { "U", "NhomCongViec_ThanhTienMay" },
        };
        public Group(unvell.ReoGrid.Worksheet worksheet, int id)
        {
            ws = worksheet;
            Id = id;
        }

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public Cell A { get { return this.Cell("A"); } }
        /// <summary>
        /// STT
        /// </summary>
        public Cell B { get { return this.Cell("B"); } }
        /// <summary>
        /// MSCV
        /// </summary>
        public Cell C { get { return this.Cell("C"); } }
        /// <summary>
        /// Đơn giá máy
        /// </summary>
        public Cell Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Tổng thành tiền vật liệu của nhóm
        /// </summary>
        public Cell R { get { return this.Cell("R"); } }
        /// Tổng thành tiền vật liệu phụ của nhóm
        public Cell S { get { return this.Cell("S"); } }
        /// <summary>
        /// Tổng thành tiền nhân công của nhóm
        /// </summary>
        public Cell T { get { return this.Cell("T"); } }
        /// <summary>
        /// Tổng thành tiền máy của nhóm
        /// </summary>
        public Cell U { get { return this.Cell("U"); } }
        /// <summary>
        /// Hệ số điều chỉnh máy
        /// </summary>
        public Cell X { get { return this.Cell("X"); } }
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
                // merge khi có dấu hiệu của group
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
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            foreach (string colName in aliasUniqueName.Keys)
            {
                string formula = string.Format(modBL.Container.Get(aliasUniqueName[colName]).formula(parameters));
                ws[colName + Id] = formula;
            }
        }
    }
}

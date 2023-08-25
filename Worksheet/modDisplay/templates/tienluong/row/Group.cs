using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.XlsIO;
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
    internal class Group : ARowObject
    {
        Dictionary<string, string> aliasUniqueName = new Dictionary<string, string>() {
            { "R", "NhomCongViec_ThanhTienVatLieu" },
            { "S", "NhomCongViec_ThanhTienVatLieuPhu" },
            { "T", "NhomCongViec_ThanhTienNhanCong" },
            { "U", "NhomCongViec_ThanhTienMay" },
        };
        public Group(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, int id) : base(spreadsheetGrid, worksheet)
        {
            ws = spreadsheetGrid;
            this.worksheet = worksheet;
            Id = id;
        }

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public IRange A { get { return this.Cell("A"); } }
        /// <summary>
        /// STT
        /// </summary>
        public IRange B { get { return this.Cell("B"); } }
        /// <summary>
        /// MSCV
        /// </summary>
        public IRange C { get { return this.Cell("C"); } }
        /// <summary>
        /// Đơn giá máy
        /// </summary>
        public IRange Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Tổng thành tiền vật liệu của nhóm
        /// </summary>
        public IRange R { get { return this.Cell("R"); } }
        /// Tổng thành tiền vật liệu phụ của nhóm
        public IRange S { get { return this.Cell("S"); } }
        /// <summary>
        /// Tổng thành tiền nhân công của nhóm
        /// </summary>
        public IRange T { get { return this.Cell("T"); } }
        /// <summary>
        /// Tổng thành tiền máy của nhóm
        /// </summary>
        public IRange U { get { return this.Cell("U"); } }
        /// <summary>
        /// Hệ số điều chỉnh máy
        /// </summary>
        public IRange X { get { return this.Cell("X"); } }
        public void bind()
        {
            // check group object khi mở từ file excel ( bind)

            string C = worksheet.Range["C" + Id].Value;
            if (C != "" && C.StartsWith("*"))
            {
                string nameGroup = C.Substring(1);
                if (nameGroup.Length == 0)
                {
                    nameGroup = "(Nhóm không tên)";
                }

                // merge khi có dấu hiệu của group
                IRange raneMerge = worksheet.Range[B.AddressLocal + ":" + Q.AddressLocal];
                GridRangeInfo gridRange = GridExcelHelper.ConvertExcelRangeToGridRange(raneMerge);  
                var excelRange = gridRange.ConvertGridRangeToExcelRange(ws);
                var coverCell = new CoveredCellInfo(gridRange.Top, gridRange.Left, gridRange.Bottom, gridRange.Right);

                ws.CoveredCells.Add(coverCell);
                worksheet.Range[excelRange].Merge();
                ws.SetCellValue(B, nameGroup);

                #region style lại cho group object

                IRange range = worksheet.Range[B.AddressLocal];
                range.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;

                string addressRangeGroup = A.AddressLocal + ":" + X.AddressLocal;
                IRange rangeGroup = worksheet.Range[addressRangeGroup];
                rangeGroup.CellStyle.ColorIndex = Syncfusion.XlsIO.ExcelKnownColors.Light_green;
                rangeGroup.BorderAround(ExcelLineStyle.Thin);

                #endregion
            }
        }

        public void render()
        {
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            foreach (string colName in aliasUniqueName.Keys)
            {
                var range = worksheet.Range[colName + Id];
                ws.SetCellValue(range, string.Format(modBL.Container.Get(aliasUniqueName[colName]).formula(parameters)));
                ws.InvalidateCell(range.Row, range.Column);
            }
        }
    }
}

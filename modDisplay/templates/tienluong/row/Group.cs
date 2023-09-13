using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.XlsIO;

namespace modDisplay.templates.tienluong.row
{
    internal class Group : ARowObject
    {
        Dictionary<string, string> aliasUniqueName = new Dictionary<string, string>() {
            { "R", "NhomCongViec_ThanhTienVatLieu" },
            { "S", "NhomCongViec_ThanhTienVatLieuPhu" },
            { "T", "NhomCongViec_ThanhTienNhanCong" },
            { "U", "NhomCongViec_ThanhTienMay" },
        };
        public Group(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, IWorksheet workingsheet, int id) : base(spreadsheetGrid, worksheet, workingsheet)
        {
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

            string C = masksheet.Range["C" + Id].Value;
            if (C != "" && C.StartsWith("*"))
            {
                string nameGroup = C.Substring(1);
                if (nameGroup.Length == 0)
                {
                    nameGroup = "(Nhóm không tên)";
                }

                // merge khi có dấu hiệu của group
                IRange raneMerge = masksheet.Range[B.AddressLocal + ":" + Q.AddressLocal];
                GridRangeInfo gridRange = GridExcelHelper.ConvertExcelRangeToGridRange(raneMerge);
                var excelRange = gridRange.ConvertGridRangeToExcelRange(spreadsheetGrid);
                var coverCell = new CoveredCellInfo(raneMerge.Row, raneMerge.Column, raneMerge.LastRow, raneMerge.LastColumn);
                //var coverCell = new CoveredCellInfo(gridRange.Top, gridRange.Left, gridRange.Bottom, gridRange.Right);

                masksheet.Range[excelRange].Merge();
                spreadsheetGrid.SetCellValue(B, nameGroup);
                spreadsheetGrid.CoveredCells.Add(coverCell);

                #region style lại cho group object

                IRange range = masksheet.Range[B.AddressLocal];
                range.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;

                string addressRangeGroup = A.AddressLocal + ":" + X.AddressLocal;
                IRange rangeGroup = masksheet.Range[addressRangeGroup];
                rangeGroup.CellStyle.ColorIndex = ExcelKnownColors.Light_green;
                rangeGroup.BorderAround(ExcelLineStyle.Thin);

                #endregion
            }
        }

        public void render()
        {
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            foreach (string colName in aliasUniqueName.Keys)
            {
                var range = masksheet.Range[colName + Id];
                BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
                spreadsheetGrid.SetCellValue(range, string.Format(modBLContainer.Get(aliasUniqueName[colName]).formula(parameters)));
            }
        }
    }
}

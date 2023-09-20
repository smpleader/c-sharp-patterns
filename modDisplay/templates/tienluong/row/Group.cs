using modDisplay.templates.tienluong.row.group;
using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.tienluong.row
{
    public class Group : ARowObject
    {
        public Group(GridControl gridControl, IWorksheet workingsheet, int id) : base(gridControl, workingsheet)
        {
            Id = id;
            cellA = new CellA(this);
            cellB = new CellB(this);
            cellC = new CellC(this);
            cellQ = new CellQ(this);
            cellR = new CellR(this);
            cellS = new CellS(this);
            cellT = new CellT(this);
            cellU = new CellU(this);
            cellX = new CellX(this);
        }

        public CellA cellA { get; set; }
        public CellB cellB { set; get; }
        public CellC cellC { set; get; }
        public CellQ cellQ { set; get; }
        public CellR cellR { set; get; }
        public CellS cellS { set; get; }
        public CellT cellT { set; get; }
        public CellU cellU { set; get; }
        public CellX cellX { set; get; }

        public void bind()
        {
            // check group object khi mở từ file excel ( bind)

            string C = cellC.ValueOnMask.ToString();
            if (C != "" && C.StartsWith("*"))
            {
                string nameGroup = C.Substring(1);
                if (nameGroup.Length == 0)
                {
                    nameGroup = "(Nhóm không tên)";
                }

                // merge khi có dấu hiệu của group
                IRange raneMerge = workingsheet.Range[cellB.Range.AddressLocal + ":" + cellQ.Range.AddressLocal];
                //GridRangeInfo gridRange = GridExcelHelper.ConvertExcelRangeToGridRange(raneMerge);
                //var excelRange = gridRange.ConvertGridRangeToExcelRange(gridControl);
                var coverCell = new CoveredCellInfo(raneMerge.Row, raneMerge.Column, raneMerge.LastRow, raneMerge.LastColumn);
                //var coverCell = new CoveredCellInfo(gridRange.Top, gridRange.Left, gridRange.Bottom, gridRange.Right);

                //masksheet.Range[excelRange].Merge();
                //gridControl.SetCellValue(B, nameGroup);
                //gridControl.CoveredCells.Add(coverCell);

                #region style lại cho group object

                IRange range = workingsheet.Range[cellB.Range.AddressLocal];
                range.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;

                string addressRangeGroup = cellA.Range.AddressLocal + ":" + cellX.Range.AddressLocal;
                IRange rangeGroup = workingsheet.Range[addressRangeGroup];
                rangeGroup.CellStyle.ColorIndex = ExcelKnownColors.Light_green;
                rangeGroup.BorderAround(ExcelLineStyle.Thin);

                #endregion
            }
        }

        public void render()
        {
            cellR.Render();
            cellS.Render();
            cellT.Render();
            cellU.Render();
        }
    }
}

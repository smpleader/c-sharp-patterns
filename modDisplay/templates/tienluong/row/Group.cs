using modDisplay.templates.tienluong.row.group;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation.Collections.Grouping;
using GridRangeInfo = Syncfusion.Windows.Forms.Grid.GridRangeInfo;

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
                IRange rangeMerge = workingsheet.Range[cellB.Range.AddressLocal + ":" + cellQ.Range.AddressLocal];

                rangeMerge.Merge();
                cellB.Range.Value = nameGroup;

                this.gridControl.Model.CoveredRanges.Add(GridRangeInfo.Cells(rangeMerge.Row, rangeMerge.Column, rangeMerge.LastRow, rangeMerge.LastColumn));
                cellB.ValueOnMask = nameGroup;

                #region style lại cho group object in workingsheet

                IRange range = workingsheet.Range[cellB.Range.AddressLocal];
                range.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;

                string addressRangeGroup = cellA.Range.AddressLocal + ":" + cellX.Range.AddressLocal;
                IRange rangeGroup = workingsheet.Range[addressRangeGroup];
                rangeGroup.CellStyle.ColorIndex = ExcelKnownColors.Light_green;
                rangeGroup.BorderAround(ExcelLineStyle.Thin);

                #endregion

                #region style lại cho group object in masksheet
                cellB.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Left;
                GridStyleInfo style = new GridStyleInfo();
                style.BackColor = Color.LightGreen;
                style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thin);
                var rangeGroupGridcontrol = GridRangeInfo.Cells(rangeGroup.Row, rangeGroup.Column, rangeGroup.LastRow, rangeGroup.LastColumn);
                this.gridControl.ChangeCells(rangeGroupGridcontrol, style, StyleModifyType.Override);
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
        public override void style()
        {
            string addressRangeGroup = cellA.Range.AddressLocal + ":" + cellX.Range.AddressLocal;
            IRange rangeGroup = workingsheet.Range[addressRangeGroup];
            rangeGroup.CellStyle.ColorIndex = ExcelKnownColors.Light_green;
            rangeGroup.BorderAround(ExcelLineStyle.Thin);
            cellB.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Left;
            GridStyleInfo style = new GridStyleInfo();
            style.BackColor = Color.LightGreen;
            style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thin);
            var rangeGroupGridcontrol = GridRangeInfo.Cells(rangeGroup.Row, rangeGroup.Column, rangeGroup.LastRow, rangeGroup.LastColumn);
            this.gridControl.ChangeCells(rangeGroupGridcontrol, style, StyleModifyType.Override);

            // style cho cột R->U
            cellR.GridStyleInfo.TextColor = cellS.GridStyleInfo.TextColor = cellT.GridStyleInfo.TextColor = cellU.GridStyleInfo.TextColor = Color.Black;
            cellR.GridStyleInfo.Format = cellS.GridStyleInfo.Format = cellT.GridStyleInfo.Format = cellU.GridStyleInfo.Format = "###,###,###,##0";
            cellR.GridStyleInfo.HorizontalAlignment = cellS.GridStyleInfo.HorizontalAlignment = cellT.GridStyleInfo.HorizontalAlignment = cellU.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right;
            cellR.GridStyleInfo.VerticalAlignment = cellS.GridStyleInfo.VerticalAlignment = cellT.GridStyleInfo.VerticalAlignment = cellU.GridStyleInfo.VerticalAlignment = GridVerticalAlignment.Top;
        }
    }
}

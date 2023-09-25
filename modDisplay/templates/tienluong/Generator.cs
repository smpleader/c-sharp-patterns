using HeaderGroup = modDisplay.templates.tienluong.Header;
using FooterGroup = modDisplay.templates.tienluong.Footer;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;

namespace modDisplay.templates.tienluong
{
    public class Generator : AGenerator
    {
        public int HeightRow = 35;
        public override string Name { get { return "templates/tienluong"; } }
        public override void init(string tabName)
        {
            if (Display.WorkSheets[tabName] != null)
            {
                gridControl = Display.ActiveGrid;
                workingsheet = Display.Workingsheets[tabName + "_" + Display.HangMucId];
            }
        }

        public override void addMenu()
        {
            Display.menuItems = new ToolStripItemCollection(Display.contextMenu,
                new ToolStripItem[]{
                    new ToolStripMenuItem("Congviec 2"),
                });
        }
        public override void loadData()
        {
            IsEditting = true;
            gridControl.Cols.Hidden.SetRange(6, 12, true);
            gridControl.Cols.Hidden.SetRange(15, 15, true);
            gridControl.Cols.Hidden.SetRange(19, 19, true);

            Positions = new Dictionary<string, APosition>()
            {
                { "Header", new HeaderGroup(gridControl, workingsheet) },
                { "Body", new Body(gridControl, workingsheet) },
                { "Footer", new FooterGroup(gridControl, workingsheet) },
            };
            // bind

            // header
            Positions["Header"].bindInWoringsheet();
            Positions["Header"].renderInWorkingsheet();

            // footer
            Positions["Footer"].bindInWoringsheet();
            Positions["Footer"].renderInWorkingsheet();

            // body 
            Positions["Body"].end = Positions["Footer"].Id - 1;
            Positions["Body"].bindInWoringsheet();
            Positions["Body"].renderInWorkingsheet();

            if (Display.ActiveMaskSheetDebug != null)
            {
                Display.showDataDebug();
            }
            if (Display.ActiveGrid != null)
            {
                Display.showData();
            }
            IsEditting = false;
        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (Positions["Body"].HasRow(selectedIndexRow))
            {
                // bắt đầu thêm công việc
                IsEditting = true;
                ((Body)Positions["Body"]).rows[selectedIndexRow] = new Row(gridControl, workingsheet, selectedIndexRow);
                Row selectedRow = ((Body)Positions["Body"]).rows[selectedIndexRow];
                selectedRow.AddSimpleData();
                ((Body)Positions["Body"]).bindInWoringsheet();
                ((Body)Positions["Body"]).renderInWorkingsheet();
                Display.showDataDebug();
                Display.showData();
                IsEditting = false;
            }
        }

        public override void selectCell()
        {
            switch (Display.Col)
            {
                case "B":
                    if (!((Body)Positions["Body"]).groups.Keys.Contains(Display.Row))
                    {
                        //Display.Cell.IsReadOnly = true;
                    }
                    break;
                case "R":
                case "S":
                case "T":
                case "U":
                    //Display.Cell.IsReadOnly = true;
                    break;
            }
            var b = Display.ActiveGrid[Display.Row, Util.CellUtility.GetExcelColumnNumber(Display.Col)];
        }

        public override void afterCellInput()
        {
            if (((Body)Position("Body")) == null) return;
            if (IsEditting) return;
            IsEditting = true;

            APosition position = Address(Display.Row);
            position.bindInMaskSheet(Display.Row);
            position.renderInWorkingsheet();

            Display.showDataDebug();
            Display.showData();
            IsEditting = false;
        }
        public override void insertRow(int indexRow, int count)
        {
            //((Body)Position("Body")).end += count;
            Positions = new Dictionary<string, APosition>()
            {
                { "Header", new HeaderGroup(gridControl, workingsheet) },
                { "Body", new Body(gridControl, workingsheet) },
                { "Footer", new FooterGroup(gridControl, workingsheet) },
            };
            // bind

            // header
            Positions["Header"].bindInWoringsheet();
            Positions["Header"].renderInWorkingsheet();

            // footer
            Positions["Footer"].bindInWoringsheet();
            Positions["Footer"].renderInWorkingsheet();

            // body 
            Positions["Body"].end = Positions["Footer"].Id - 1;
            Positions["Body"].bindInWoringsheet();
            Positions["Body"].renderInWorkingsheet();

            if (Display.ActiveMaskSheetDebug != null)
            {
                Display.showDataDebug();
            }
            if (Display.ActiveGrid != null)
            {
                Display.showData();
            }
            Style();
            int i = 0;
            while(count>i)
            {
                Display.ActiveGrid.RowHeights[indexRow-i] = HeightRow;
                i++;
            }
        }

        public void Style()
        {
            // style cho cột B
            GridStyleInfo styleColB = new GridStyleInfo();
            styleColB.HorizontalAlignment = GridHorizontalAlignment.Center;
            styleColB.VerticalAlignment = GridVerticalAlignment.Top;
            styleColB.TextColor = Color.Black;
            int colB = Util.CellUtility.GetExcelColumnNumber("B");
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, colB, Positions["Body"].end, colB), styleColB, StyleModifyType.Override);

            // style cho cột C
            GridStyleInfo styleColC = new GridStyleInfo();
            styleColC.TextColor = Color.Black;
            int colC = Util.CellUtility.GetExcelColumnNumber("C");
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, colC, Positions["Body"].end, colC), styleColC, StyleModifyType.Override);

            // style cho cột D
            GridStyleInfo styleColD = new GridStyleInfo();
            styleColD.TextColor = Color.Black;
            int colD = Util.CellUtility.GetExcelColumnNumber("D");
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, colD, Positions["Body"].end, colD), styleColD, StyleModifyType.Override);

            // style cho cột E
            GridStyleInfo styleColE = new GridStyleInfo();
            styleColE.HorizontalAlignment = GridHorizontalAlignment.Center;
            styleColE.VerticalAlignment = GridVerticalAlignment.Top;
            styleColE.TextColor = Color.Black;
            int colE = Util.CellUtility.GetExcelColumnNumber("E");
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, colE, Positions["Body"].end, colE), styleColE, StyleModifyType.Override);

            // style cho cột M
            GridStyleInfo styleColM = new GridStyleInfo();
            styleColM.TextColor = Color.Blue;
            styleColM.HorizontalAlignment = GridHorizontalAlignment.Right;
            styleColM.VerticalAlignment = GridVerticalAlignment.Top;
            styleColM.Format = "###,###,##0.0000";
            int colG = Util.CellUtility.GetExcelColumnNumber("M");
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, colG, Positions["Body"].end, colG), styleColM, StyleModifyType.Override);

            // style cho cột N->U
            GridStyleInfo styleColNU = new GridStyleInfo();
            styleColNU.TextColor = Color.Black;
            styleColNU.Format = "###,###,###,##0";
            styleColNU.HorizontalAlignment = GridHorizontalAlignment.Right;
            styleColNU.VerticalAlignment = GridVerticalAlignment.Top;
            int colN = Util.CellUtility.GetExcelColumnNumber("N");
            int colU = Util.CellUtility.GetExcelColumnNumber("U");
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, colN, Positions["Body"].end, colU), styleColNU, StyleModifyType.Override);

            // style cho cột V->X
            GridStyleInfo styleColVX = new GridStyleInfo();
            styleColVX.TextColor = Color.Blue;
            styleColVX.HorizontalAlignment = GridHorizontalAlignment.Right;
            styleColVX.VerticalAlignment = GridVerticalAlignment.Top;
            int colV = Util.CellUtility.GetExcelColumnNumber("V");
            int colX = Util.CellUtility.GetExcelColumnNumber("X");
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, colV, Positions["Body"].end, colX), styleColVX, StyleModifyType.Override);

            // Creates a GridStyleInfo object.
            GridStyleInfo styleBody = new GridStyleInfo();

            // Set values and properties.

            styleBody.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thin);
            styleBody.Borders.Bottom = new GridBorder(GridBorderStyle.Dotted, Color.Black, GridBorderWeight.Thin);
            styleBody.Font.Facename = "Times New Roman";
            styleBody.Font.Size = 11.0f;

            // Applies styles to a range of cells.
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, Util.CellUtility.GetExcelColumnNumber("A"), Positions["Body"].end, Util.CellUtility.GetExcelColumnNumber("X")), styleBody, StyleModifyType.Override);


            GridStyleInfo styleFooter = new GridStyleInfo();
            // Set values and properties.
            styleFooter.Borders.Top = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thin);
            styleFooter.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thin);
            styleFooter.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thin);

            // Applies styles to a range of cells.
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Footer"].Id, Util.CellUtility.GetExcelColumnNumber("A"), Positions["Footer"].Id, Util.CellUtility.GetExcelColumnNumber("X")), styleFooter, StyleModifyType.Override);

        }

        public override void deleteRow(int indexRow, int count)
        {
            //((Body)Position("Body")).end -= count;
            Positions = new Dictionary<string, APosition>()
            {
                { "Header", new HeaderGroup(gridControl, workingsheet) },
                { "Body", new Body(gridControl, workingsheet) },
                { "Footer", new FooterGroup(gridControl, workingsheet) },
            };
            // bind

            // header
            Positions["Header"].bindInWoringsheet();
            Positions["Header"].renderInWorkingsheet();

            // footer
            Positions["Footer"].bindInWoringsheet();
            Positions["Footer"].renderInWorkingsheet();

            // body 
            Positions["Body"].end = Positions["Footer"].Id - 1;
            Positions["Body"].bindInWoringsheet();
            Positions["Body"].renderInWorkingsheet();

            if (Display.ActiveMaskSheetDebug != null)
            {
                Display.showDataDebug();
            }
            if (Display.ActiveGrid != null)
            {
                Display.showData();
            }
        }
    }
}

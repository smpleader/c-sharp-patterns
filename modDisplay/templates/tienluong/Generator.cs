using HeaderGroup = modDisplay.templates.tienluong.Header;
using FooterGroup = modDisplay.templates.tienluong.Footer;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using Syncfusion.XlsIO;

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
                workingsheet.EnableSheetCalculations();
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
            Style();

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
            ((Body)Positions["Body"]).Style();

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
            Style();

            if (((Body)Position("Body")) == null) return;
            if (IsEditting) return;
            IsEditting = true;

            APosition position = Address(Display.Row);
            position.bindInMaskSheet(Display.Row);
            position.renderInWorkingsheet();

            Display.showDataDebug();
            Display.showData();
            ((Body)Positions["Body"]).Style();

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
            ((Body)Positions["Body"]).Style();
        }
        IStyle rowStyle;
        public void Style()
        {
            Display.ActiveGrid.SuspendLayout();
            //clear style 
            GridStyleInfo styleInfo = new GridStyleInfo();
            styleInfo.Borders.All = new GridBorder(GridBorderStyle.Standard);
            styleInfo.BackColor = Color.White;

            //Define new styles to apply in rows and columns
            if(!Display.workbook.Styles.Contains("RowStyle"))
            {
                rowStyle = Display.workbook.Styles.Add("RowStyle");
            }
            rowStyle.Color = Color.White;
            for (int row = Positions["Body"].start; row <= Positions["Body"].end; row ++)
            {
                Display.ActiveSheet.SetDefaultRowStyle(row, rowStyle);
            }
            Display.ActiveGrid.ChangeCells(GridRangeInfo.Cells(Positions["Body"].start, Util.CellUtility.GetExcelColumnNumber("A"), Positions["Body"].end, Util.CellUtility.GetExcelColumnNumber("X")), styleInfo, StyleModifyType.Override);

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
            Display.ActiveGrid.ResumeLayout(false);
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
            Style();
            ((Body)Positions["Body"]).Style();
        }
    }
}

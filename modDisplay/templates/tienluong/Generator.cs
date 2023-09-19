using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms.Spreadsheet;
using HeaderGroup = modDisplay.templates.tienluong.Header;
using FooterGroup = modDisplay.templates.tienluong.Footer;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;

namespace modDisplay.templates.tienluong
{
    public class Generator : AGenerator
    {
        public override string Name { get { return "templates/tienluong"; } }
        public override void init(string tabName)
        {
            if (Display.WorkSheets[tabName] != null)
            {
                masksheet = Display.WorkSheets[tabName];
                gridControl = Display.ActiveGrid;
                workingsheet = Display.Workingsheets[tabName + "_" + Display.HangMucId];
                masksheet.UseRangesCache = false;
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
            gridControl.Cols.Hidden.SetRange(14, 14, true);
            gridControl.Cols.Hidden.SetRange(18, 18, true);
            Positions = new Dictionary<string, APosition>()
            {
                { "Header", new HeaderGroup(gridControl, masksheet, workingsheet) },
                { "Body", new Body(gridControl, masksheet, workingsheet) },
                { "Footer", new Body(gridControl, masksheet, workingsheet) },

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

            IsEditting = false;
        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= Positions["Body"].start && selectedIndexRow <= Positions["Body"].end)
            {
                // bắt đầu thêm công việc
                IsEditting = true;
                ((Body)Positions["Body"]).rows[selectedIndexRow] = new Row(gridControl, masksheet, workingsheet, selectedIndexRow);
                Row selectedRow = ((Body)Positions["Body"]).rows[selectedIndexRow];
                selectedRow.AddSimpleData();
                ((Body)Positions["Body"]).bind();
                ((Body)Positions["Body"]).render();
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
    }
}

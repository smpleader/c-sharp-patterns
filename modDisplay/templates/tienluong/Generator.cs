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

        HeaderGroup header;
        FooterGroup footer;
        Body body;

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

            // bind

            // header
            header = new HeaderGroup(gridControl, masksheet, workingsheet);
            header.bind();
            header.render();

            // footer
            footer = new FooterGroup(gridControl, masksheet, workingsheet);
            footer.bind();
            footer.render();

            // body 
            body = new Body(gridControl, masksheet, workingsheet);
            body.end = footer.Id - 1;
            body.bind();
            body.render();
            IsEditting = false;

        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm công việc
                IsEditting = true;
                body.rows[selectedIndexRow] = new Row(gridControl, masksheet, workingsheet, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                selectedRow.AddSimpleData();
                body.bind();
                body.render();
                IsEditting = false;
            }
        }

        public override void selectCell()
        {
            switch (Display.Col)
            {
                case "B":
                    if (!body.groups.Keys.Contains(Display.Row))
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
            if (body == null) return;
            body.bind();
            body.render();
        }
    }
}

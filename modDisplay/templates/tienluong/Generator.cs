﻿using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms.Spreadsheet;
using HeaderGroup = modDisplay.templates.tienluong.Header;
using FooterGroup = modDisplay.templates.tienluong.Footer;
using modDisplay.templates.tienluong.row;

namespace modDisplay.templates.tienluong
{
    public class Generator : AGenerator
    {
        public override string Name { get { return "templates/tienluong"; } }
        public SpreadsheetGrid spreadsheetGrid;
        public IWorksheet masksheet;
        public IWorksheet workingsheet;

        bool DangThemCongViec = false;
        HeaderGroup header;
        FooterGroup footer;
        Body body;

        public override void init(string tabName)
        {
            if (Display.WorkSheets[tabName] != null)
            {
                masksheet = Display.WorkSheets[tabName];
                spreadsheetGrid = Display.GridCollection[tabName];
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
            DangThemCongViec = true;
            spreadsheetGrid.ColumnWidths.SetHidden(6, 12, true);
            spreadsheetGrid.ColumnWidths.SetHidden(14, 14, true);
            spreadsheetGrid.ColumnWidths.SetHidden(18, 18, true);

            // bind

            // header
            header = new HeaderGroup(spreadsheetGrid, masksheet, workingsheet);
            header.bind();
            header.render();

            // footer
            footer = new FooterGroup(spreadsheetGrid, masksheet, workingsheet);
            footer.bind();
            footer.render();

            // body 
            body = new Body(spreadsheetGrid, masksheet, workingsheet);
            body.end = footer.Id - 1;
            body.bind();
            body.render();
            DangThemCongViec = false;

        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm công việc
                DangThemCongViec = true;
                body.rows[selectedIndexRow] = new Row(spreadsheetGrid, masksheet, workingsheet, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                selectedRow.AddSimpleData();
                body.bind();
                body.render();
                DangThemCongViec = false;
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

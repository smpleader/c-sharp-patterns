using modDisplay.templates.cuocoto.tongculy.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using HeaderGroup = modDisplay.templates.cuocoto.tongculy.Header;

namespace modDisplay.templates.cuocoto.tongculy
{
    public class Generator : AGenerator
    {
        public override string Name { get { return "templates/cuocoto/tongculy"; } }

        public GridControl spreadsheetGrid;
        public IWorksheet masksheet;
        public IWorksheet workingsheet;
        bool DangThemVatLieu = false;
        HeaderGroup header;
        Body body;

        public override void init(string tabName)
        {
            if (Display.WorkSheets[tabName] != null)
            {
                masksheet = Display.WorkSheets[tabName];
                spreadsheetGrid = Display.ActiveGrid;
                workingsheet = Display.Workingsheets[tabName + "_" + Display.HangMucId];
                masksheet.UseRangesCache = false;
            }
        }

        public override void loadData()
        {
            // header
            header = new HeaderGroup(spreadsheetGrid, masksheet, workingsheet);
            header.bind();
            header.render();

            body = new Body(spreadsheetGrid, masksheet, workingsheet);
            body.bind();
            body.render();
        }
        public override void afterCellInput()
        {
            if (body != null)
            {
                if (!DangThemVatLieu)
                {
                    DangThemVatLieu = true;
                    header.bind();
                    header.render();

                    body.bind();
                    body.render();
                    DangThemVatLieu = false;
                }
            }

        }

        internal void updateData()
        {
            // thêm vật liệu vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm vật liệu
                DangThemVatLieu = true;
                body.rows[selectedIndexRow] = new Row(spreadsheetGrid, masksheet, workingsheet, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                spreadsheetGrid.BeginUpdate();
                selectedRow.AddSimpleData();
                body.bind();
                body.render();
                spreadsheetGrid.EndUpdate();
                DangThemVatLieu = false;
            }
            else
            {
                MessageBox.Show($"Chỉ được thêm dữ liệu trong khoảng từ dòng {body.start} - {body.end}");
            }
        }
    }
}

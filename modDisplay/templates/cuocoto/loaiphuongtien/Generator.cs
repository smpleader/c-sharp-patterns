using modDisplay.templates.cuocoto.loaiphuongtien.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;


namespace modDisplay.templates.cuocoto.loaiphuongtien
{
    public class Generator : AGenerator
    {
        public override string Name { get { return "templates/cuocoto/loaiphuongtien"; } }

        public GridControl gridControl;
        public IWorksheet masksheet;
        public IWorksheet workingsheet;
        bool DangThemVatLieu = false;
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

        public override void loadData()
        {
            body = new Body(gridControl, masksheet, workingsheet);
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
                    body.bind();
                    body.render();
                    DangThemVatLieu = false;
                }
            }

        }
        internal void ThayDoiPPT()
        {
            if (body == null) return;
            DangThemVatLieu = true;
            body.bind();
            body.render();
            DangThemVatLieu = false;
        }

        internal void updateData()
        {
            // thêm vật liệu vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm vật liệu
                DangThemVatLieu = true;
                body.rows[selectedIndexRow] = new Row(gridControl, masksheet, workingsheet , selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                gridControl.BeginUpdate();
                selectedRow.AddSimpleData();
                body.bind();
                body.render();
                gridControl.EndUpdate();
                DangThemVatLieu = false;
            }
        }
    }
}

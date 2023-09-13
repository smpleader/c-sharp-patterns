using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace modDisplay.templates.vatlieu
{
    public class Generator : AGenerator
    {
        public override string Name { get { return "templates/giavatlieu"; } }

        public SpreadsheetGrid spreadsheetGrid;
        public IWorksheet masksheet;
        public IWorksheet workingsheet;

        bool IsEditting = false;
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


        public override void loadData()
        {
            body = new Body(spreadsheetGrid, masksheet, workingsheet);
            // todo: chuyển lại vị trí render và bind do sau mở công trình cũ cần lấy dữ liệu từ workingfile
            body.bindInWoringsheet();
            body.renderInWorkingsheet();
            if(Display.ActiveMaskSheetDebug!=null)
            {
                Display.showDataDebug();
            }
            if (Display.ActiveGrid != null)
            {
                Display.showData();
            }
        }

        public override void selectCell()
        {
            switch (Display.Col)
            {
                case "B":
                    if (!body.rows.Keys.Contains(Display.Row))
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
            if (IsEditting) return;
            IsEditting = true;

            //todo: detect header

            if( body.HasRow(Display.Row))
            {
                body.bindInMaskSheet(Display.Row);
                body.renderInWorkingsheet();

                Display.showDataDebug();
                Display.showData();
            }    

            IsEditting = false;
        }
        public void ThayDoiPPT()
        {
            if (body == null) return;
            IsEditting = true;

            body.renderInWorkingsheet();

            Display.showDataDebug();
            Display.showData();

            IsEditting = false;
        }

        public void UpdateData()
        {
            // thêm vật liệu vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm vật liệu
                body.rows[selectedIndexRow] = new Row(spreadsheetGrid, masksheet, workingsheet, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];

                spreadsheetGrid.BeginUpdate();

                selectedRow.AddSimpleData();

                body.bindInWoringsheet();
                body.renderInWorkingsheet();

                spreadsheetGrid.EndUpdate();

                Display.showDataDebug();
                Display.showData();
            }
        }
    }
}

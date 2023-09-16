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

        HeaderGroup header;
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
            // header
            header = new HeaderGroup(gridControl, masksheet, workingsheet);
            header.bind();
            header.render();

            body = new Body(gridControl, masksheet, workingsheet);
            body.bind();
            body.render();
        }
        public override void afterCellInput()
        {
            if (body != null)
            {
                if (!IsEditting)
                {
                    IsEditting = true;
                    header.bind();
                    header.render();

                    body.bind();
                    body.render();
                    IsEditting = false;
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
                IsEditting = true;
                body.rows[selectedIndexRow] = new Row(gridControl, masksheet, workingsheet, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                gridControl.BeginUpdate();
                selectedRow.AddSimpleData();
                body.bind();
                body.render();
                gridControl.EndUpdate();
                IsEditting = false;
            }
            else
            {
                MessageBox.Show($"Chỉ được thêm dữ liệu trong khoảng từ dòng {body.start} - {body.end}");
            }
        }
    }
}

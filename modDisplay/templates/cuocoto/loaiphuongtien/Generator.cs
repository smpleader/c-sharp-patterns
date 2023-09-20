using modDisplay.templates.cuocoto.loaiphuongtien.row;

namespace modDisplay.templates.cuocoto.loaiphuongtien
{
    public class Generator : AGenerator
    {
        public override string Name { get { return "templates/cuocoto/loaiphuongtien"; } }
        Body body;

        public override void init(string tabName)
        {
            if (Display.WorkSheets[tabName] != null)
            {
                gridControl = Display.ActiveGrid;
                workingsheet = Display.Workingsheets[tabName + "_" + Display.HangMucId];
            }
        }

        public override void loadData()
        {
            body = new Body(gridControl, workingsheet);
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
                    body.bind();
                    body.render();
                    IsEditting = false;
                }
            }

        }
        internal void ThayDoiPPT()
        {
            if (body == null) return;
            IsEditting = true;
            body.bind();
            body.render();
            IsEditting = false;
        }

        internal void updateData()
        {
            // thêm vật liệu vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm vật liệu
                IsEditting = true;
                body.rows[selectedIndexRow] = new Row(gridControl, workingsheet , selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                gridControl.BeginUpdate();
                selectedRow.AddSimpleData();
                body.bind();
                body.render();
                gridControl.EndUpdate();
                IsEditting = false;
            }
        }
    }
}

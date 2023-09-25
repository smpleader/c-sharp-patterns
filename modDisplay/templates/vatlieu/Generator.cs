
namespace modDisplay.templates.vatlieu
{
    public class Generator : AGenerator
    {
        public override string Name { get { return "templates/giavatlieu"; } }
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
            Positions = new Dictionary<string, APosition>()
            {
                { "Body", new Body(gridControl, workingsheet) },
            };

            // todo: chuyển lại vị trí render và bind do sau mở công trình cũ cần lấy dữ liệu từ workingfile
            ((Body)Position("Body")).bindInWoringsheet();
            ((Body)Position("Body")).renderInWorkingsheet();
            if(Display.ActiveMaskSheetDebug != null)
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
                    var a = Display.Cell;
                    if (!((Body)Position("Body")).rows.Keys.Contains(Display.Row))
                    {
                        //Display.Cell.IsReadOnly = true;
                    }
                    var b = Display.ActiveGrid[Display.Row, Util.CellUtility.GetExcelColumnNumber( Display.Col )];
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
             
        public void ThayDoiPPT()
        {
            if (((Body)Position("Body")) == null) return;
            IsEditting = true;

            ((Body)Position("Body")).renderInWorkingsheet();

            Display.showDataDebug();
            Display.showData();

            IsEditting = false;
        }

        public void UpdateData()
        {
            // thêm vật liệu vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= ((Body)Positions["Body"]).start && selectedIndexRow <= ((Body)Position("Body")).end)
            {
                // bắt đầu thêm vật liệu
                ((Body)Position("Body")).rows[selectedIndexRow] = new Row(gridControl, workingsheet, selectedIndexRow);
                Row selectedRow = ((Body)Position("Body")).rows[selectedIndexRow];

                gridControl.BeginUpdate();

                selectedRow.AddSimpleData();

                ((Body)Position("Body")).bindInWoringsheet();
                ((Body)Position("Body")).renderInWorkingsheet();

                gridControl.EndUpdate();

                Display.showDataDebug();
                Display.showData();
            }
        }
    }
}

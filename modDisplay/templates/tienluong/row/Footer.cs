using modDisplay.templates.tienluong.row.footer;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;


namespace modDisplay.templates.tienluong.row
{
    public class Footer : ARowObject
    {
        public Footer(GridControl gridControl, IWorksheet workingsheet) : base(gridControl, workingsheet)
        {
            Id = 16;
            start = 6;
            cellA = new CellA(this);
            cellR = new CellR(this);
            cellS = new CellS(this);
            cellT = new CellT(this);
            cellU = new CellU(this);
        }
        public CellA cellA { get; set; }
        public CellR cellR { get; set; }
        public CellS cellS { get; set; }
        public CellT cellT { get; set; }
        public CellU cellU { get; set; }
        
        public void bind()
        {
            Id = this.FindIndexRowFooter(gridControl, workingsheet, start);
            end = Id - 1;
        }

        public void render()
        {
            // todo: render lại khi thêm hoặc xóa dòng
            cellR.Render();
            cellS.Render();
            cellT.Render();
            cellU.Render();
        }
    }
}

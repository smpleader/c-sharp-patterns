using modDisplay.row;
using modDisplay.templates.cuocoto.loaiphuongtien.row.additional;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row
{
    public class AdditionalRow : ARowObject
    {
        public AdditionalRow(GridControl gridControl, IWorksheet workingsheet, int id, int parentId) : base(gridControl, workingsheet)
        {
            Id = id;
            ParentId = parentId;
            cellB = new CellB(this);
            cellC = new CellC(this);
            cellK = new CellK(this);
            cellJ = new CellJ(this);
            cellL = new CellL(this);
        }
        public int ParentId { get; set; }
        public CellB cellB { get; set; }
        public CellC cellC { get; set; }
        public CellJ cellJ { get; set; }
        public CellK cellK { get; set; }
        public CellL cellL { get; set; }

        public void bind()
        {
           
        }

        internal void render()
        {
            cellL.Render();
        }
    }
}

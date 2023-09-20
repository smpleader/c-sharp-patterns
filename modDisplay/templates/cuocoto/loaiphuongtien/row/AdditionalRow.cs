using modDisplay.row;
using modDisplay.templates.cuocoto.loaiphuongtien.row.additional;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row
{
    public class AdditionalRow : ARowObject
    {
        public AdditionalRow(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet, int id, int parentId) : base(gridControl, worksheet, workingsheet)
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
            string A = masksheet.Range["A" + Id].Value;
            if (string.IsNullOrWhiteSpace(A))
            {
                // todo: detect an additional line
            }
        }

        internal void render()
        {
            cellL.Render();
        }
    }
}

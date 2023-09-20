using modDisplay.templates.cuocoto.tongculy.row.additional;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.tongculy.row
{
    public class AdditionalRow : ARowObject
    {
        public AdditionalRow(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet, int id, int parentId) : base(gridControl, worksheet, workingsheet)
        {
            Id = id;
            ParentId = parentId;
            cellH = new CellH(this);
            cellI = new CellI(this);
            cellJ = new CellJ(this);
            cellK = new CellK(this);
            cellL = new CellL(this);
            cellM = new CellM(this);
            cellN = new CellN(this);
            cellO = new CellO(this);
            cellP = new CellP(this);
            cellS = new CellS(this);
            cellT = new CellT(this);
            cellU = new CellU(this);
            cellV = new CellV(this);
            cellW = new CellW(this);
        }
        public int ParentId { get; set; }
        public CellH cellH { get; set; }
        public CellI cellI { get; set; }
        public CellJ cellJ { get; set; }
        public CellK cellK { get; set; }
        public CellL cellL { get; set; }
        public CellM cellM { set; get; }
        public CellN cellN { set; get; }
        public CellO cellO { set; get; }
        public CellP cellP { set; get; }
        public CellQ cellQ { set; get; }
        public CellS cellS { set; get; }
        public CellT cellT { set; get; }
        public CellU cellU { set; get; }
        public CellV cellV { set; get; }
        public CellW cellW { set; get; }
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
            cellO.Render();
            cellP.Render();
        }
    }
}

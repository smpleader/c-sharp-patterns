using modDisplay.templates.cuocoto.tongculy.row.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.tongculy.row
{
    public class Row : ARowObject
    {
        public Row(GridControl gridControl, IWorksheet workingsheet, int id) : base(gridControl, workingsheet)
        {
            Id = id;
            cellA = new CellA(this);
            cellB = new CellB(this);
            cellC = new CellC(this);
            cellD = new CellD(this);
            cellE = new CellE(this);    
            cellF = new CellF(this);
            cellG = new CellG(this);
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
            cellX = new CellX(this);

        }
        public bool HaveAdditionalLines { get; set; } = false;
        public CellA cellA { get; set; }
        public CellB cellB { get; set; }
        public CellC cellC { get; set; }
        public CellD cellD { get; set; }
        public CellE cellE { get; set; }
        public CellF cellF { get; set; }
        public CellG cellG { get; set; }
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
        public CellX cellX { set; get; }
        internal void bind()
        {
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            cellM.Render();
            cellO.Render();
            cellP.Render();
            cellS.Render();
            cellX.Render();
        }
        public void AddSimpleData()
        {
            //gridControl.SetCellValue(B, "V01897");
            //gridControl.SetCellValue(C, "Cát vàng");
            //gridControl.SetCellValue(D, "m3");
            //gridControl.SetCellValue(E, "1.45");
            //gridControl.SetCellValue(F, "Bậc 1");
            //gridControl.SetCellValue(G, "1.0");
            //gridControl.SetCellValue(I, "Ô tô");
            //gridControl.SetCellValue(J, "1.0");
            //gridControl.SetCellValue(K, "Loại 1");

            //gridControl.SetCellValue(N, "2984");
        }
    }
}

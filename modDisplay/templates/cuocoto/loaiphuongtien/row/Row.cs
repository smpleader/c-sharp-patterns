using modDisplay.templates.cuocoto.loaiphuongtien.row.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row
{
    public class Row : ARowObject
    {
        public Row(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet, int id) : base(gridControl, worksheet, workingsheet)
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
        }

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

        internal void bind()
        {
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            cellJ.Render();
            cellL.Render();
            cellP.Render();
            cellT.Render();
        }
        public void AddSimpleData()
        {
            //gridControl.SetCellValue(C, "V01897");
            //gridControl.SetCellValue(E, "Cát vàng");
            //gridControl.SetCellValue(F, "m3");

            //gridControl.SetCellValue(K, "1");
            //gridControl.SetCellValue(G, "389809");
            //gridControl.SetCellValue(J, "389809");
        }
    }
}

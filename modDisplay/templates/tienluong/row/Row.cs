using modDisplay.templates.tienluong.row.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.tienluong.row
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
            cellQ = new CellQ(this);
            cellR = new CellR(this);
            cellS = new CellS(this);
            cellT = new CellT(this);
            cellU = new CellU(this);
            cellV = new CellV(this);
            cellW = new CellW(this);
            cellX = new CellX(this);
            cellY = new CellY(this);
            cellZ = new CellZ(this);
            cellAA = new CellAA(this);
            cellAB = new CellAB(this);
            cellAC = new CellAC(this);
        }

        public bool HaveInterpretiveFormula = false;
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
        public CellM cellM { get; set; }
        public CellN cellN { get; set; }
        public CellO cellO { get; set; }
        public CellP cellP { get; set; }
        public CellQ cellQ { get; set; }
        public CellR cellR { get; set; }
        public CellS cellS { get; set; }
        public CellT cellT { get; set; }
        public CellU cellU { get; set; }
        public CellV cellV { get; set; }
        public CellW cellW { get; set; }
        public CellX cellX { get; set; }
        public CellY cellY { get; set; }
        public CellZ cellZ { get; set; }
        public CellAA cellAA { get; set; }
        public CellAB cellAB { get; set; }
        public CellAC cellAC { get; set; }
       
        public void bind()
        {

        }
       
        public void render()
        {
            // xử lý công thức cho cột M
            cellM.Render();
            // xử lý công thức cho cột N, O, P, Q
            cellN.Render();
            cellO.Render();
            cellP.Render();
            cellQ.Render();
            // xử lý công thức cho cột R, S, T, U
            cellR.Render();
            cellS.Render();
            cellT.Render();
            cellU.Render();
        }

        public void AddSimpleData()
        {
            //gridControl.SetCellValue(C, "AG.11111");
            //gridControl.SetCellValue(D, "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)");
            //gridControl.SetCellValue(E, "m3");

            //gridControl.SetCellValue(V, "1");
            //gridControl.SetCellValue(W, "1");
            //gridControl.SetCellValue(X, "1");

            //gridControl.SetCellValue(Y, "DinhMuc_2021XD_D12");

            //gridControl.SetCellValue(Z, "685204");
            //gridControl.SetCellValue(AA, "0");
            //gridControl.SetCellValue(AB, "288111");
            //gridControl.SetCellValue(AC, "70230");

            // set màu chữ thành không màu
            IRange range = masksheet.Range[cellZ.Range.AddressLocal + ":" + cellAC.Range.AddressLocal];
            range.CellStyle.Font.Color = Syncfusion.XlsIO.ExcelKnownColors.White;
        }
    }
}

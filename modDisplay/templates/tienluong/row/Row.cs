using modDisplay.templates.tienluong.row.row;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.tienluong.row
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
            cellC.Bind();
            cellD.Bind();
            cellE.Bind();
            cellM.Bind();
            cellV.Bind();
            cellW.Bind();
            cellX.Bind();
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
            Display.ActiveMaskSheetDebug = Display.WorkSheetsDebug["Tiên lượng"];

            cellC.Range.Value2 = "AG.11111";
            cellD.Range.Value2 = "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)";
            cellE.Range.Value2 = "m3";
            cellV.Range.Value2 = 1;
            cellW.Range.Value2 = 1;
            cellX.Range.Value2 = 1;

            cellY.Range.Value2 = "DinhMuc_2021XD_D12";
            cellZ.Range.Value2 = 685204;
            cellAA.Range.Value2 = 0;
            cellAB.Range.Value2 = 288111;
            cellAC.Range.Value2 = 70230;

            // set màu chữ thành không màu
            IRange range = workingsheet.Range[cellZ.Range.AddressLocal + ":" + cellAC.Range.AddressLocal];
            range.CellStyle.Font.Color = Syncfusion.XlsIO.ExcelKnownColors.White;
        }
        public override void style()
        {
            // style cho cột B
            cellB.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
            cellB.GridStyleInfo.VerticalAlignment = GridVerticalAlignment.Top;
            cellB.GridStyleInfo.TextColor = Color.Black;

            // style cho cột C
            cellC.GridStyleInfo.TextColor = Color.Black;

            // style cho cột D
            cellD.GridStyleInfo.TextColor = Color.Black;

            // style cho cột E
            cellE.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
            cellE.GridStyleInfo.VerticalAlignment = GridVerticalAlignment.Top;
            cellE.GridStyleInfo.TextColor = Color.Black;

            // style cho cột M
            cellM.GridStyleInfo.TextColor = Color.Blue;
            cellM.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right;
            cellM.GridStyleInfo.VerticalAlignment = GridVerticalAlignment.Top;
            cellM.GridStyleInfo.Format = "###,###,##0.0000";

            // style cho cột N->U
            //cellN.GridStyleInfo.BackColor = Color.LightPink;
            cellN.GridStyleInfo.TextColor = cellO.GridStyleInfo.TextColor = cellP.GridStyleInfo.TextColor = cellQ.GridStyleInfo.TextColor
                = cellR.GridStyleInfo.TextColor = cellS.GridStyleInfo.TextColor = cellT.GridStyleInfo.TextColor = cellU.GridStyleInfo.TextColor = Color.Black;
            cellN.GridStyleInfo.Format = cellO.GridStyleInfo.Format = cellP.GridStyleInfo.Format = cellQ.GridStyleInfo.Format
                = cellR.GridStyleInfo.Format = cellS.GridStyleInfo.Format = cellT.GridStyleInfo.Format = cellU.GridStyleInfo.Format = "###,###,###,##0";
            cellN.GridStyleInfo.HorizontalAlignment = cellO.GridStyleInfo.HorizontalAlignment = cellP.GridStyleInfo.HorizontalAlignment = cellQ.GridStyleInfo.HorizontalAlignment
                = cellR.GridStyleInfo.HorizontalAlignment = cellS.GridStyleInfo.HorizontalAlignment = cellT.GridStyleInfo.HorizontalAlignment = cellU.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right;
            cellN.GridStyleInfo.VerticalAlignment = cellO.GridStyleInfo.VerticalAlignment = cellP.GridStyleInfo.VerticalAlignment = cellQ.GridStyleInfo.VerticalAlignment
                = cellR.GridStyleInfo.VerticalAlignment = cellS.GridStyleInfo.VerticalAlignment = cellT.GridStyleInfo.VerticalAlignment = cellU.GridStyleInfo.VerticalAlignment = GridVerticalAlignment.Top;

            // style cho cột V->X
            cellV.GridStyleInfo.TextColor = cellW.GridStyleInfo.TextColor = cellX.GridStyleInfo.TextColor = Color.Blue;
            cellV.GridStyleInfo.HorizontalAlignment = cellW.GridStyleInfo.HorizontalAlignment = cellX.GridStyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right;
            cellV.GridStyleInfo.VerticalAlignment = cellW.GridStyleInfo.VerticalAlignment = cellX.GridStyleInfo.VerticalAlignment = GridVerticalAlignment.Top;
        }
    }
}

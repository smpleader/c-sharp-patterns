using modDisplay.row;
using modDisplay.templates.vatlieu.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace modDisplay.templates.vatlieu
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
        }

        /// <summary>
        /// Số thứ tự
        /// </summary>
        public CellA cellA;
        /// <summary>
        /// Mã vật liệu
        /// </summary>
        public CellB cellB;
        /// <summary>
        /// Tên vật liệu
        /// </summary>
        public CellC cellC;
        /// <summary>
        /// Đơn vị
        /// </summary>
        public CellD cellD;
        /// <summary>
        /// Giá gốc
        /// </summary>
        public CellE cellE;
        /// <summary>
        /// Giá TB
        /// </summary>
        public CellF cellF;
        /// <summary>
        /// Hệ số
        /// </summary>
        public CellG cellG;
        /// <summary>
        /// Giá TBxHS
        /// </summary>
        public CellH cellH;
        /// <summary>
        /// Cước ô tô
        /// </summary>
        public CellI cellI;
        /// <summary>
        /// Cước sông
        /// </summary>
        public CellJ cellJ;
        /// <summary>
        /// Cước thủ công
        /// </summary>
        public CellK cellK;
        /// <summary>
        /// Cước biển
        /// </summary>
        public CellL cellL;
        /// <summary>
        /// Cước khác
        /// </summary>
        public CellM cellM;
        /// <summary>
        /// Tổng cước
        /// </summary>
        public CellN cellN;
        /// <summary>
        /// Giá hiện trường	
        /// </summary>
        public CellO cellO;
        /// <summary>
        /// Ghi chú
        /// </summary>
        public CellP cellP;

        internal void bind()
        {
            cellB.Bind();
            cellC.Bind();
            cellD.Bind();
            cellE.Bind();
            cellF.Bind();
            cellP.Bind();
            cellM.Bind();
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            cellA.Render();
            cellB.Render();
            cellC.Render();
            cellD.Render();
            cellE.Render();
            cellF.Render();
            cellG.Render();
            cellH.Render();
            cellI.Render();
            cellJ.Render();
            cellK.Render();
            cellL.Render();
            cellM.Render();
            cellN.Render();
            cellO.Render();
            cellP.Render();
        }
        public void AddSimpleData()
        {
            Display.ActiveMaskSheetDebug = Display.WorkSheetsDebug["Giá vật liệu"];

            // Add data ở working sheet
            cellB.Range.Text = "V01897";
            cellC.Range.Text = "Cát vàng";
            cellD.Range.Text = "m3";
            cellG.Range.Number = 1;
            cellE.Range.Number = 389809;
            cellF.Range.Number = 389809;
        }
    }
}

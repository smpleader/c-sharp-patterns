using modBL.prime.dongiatonghop;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using static modDisplay.templates.vatlieu.Row;

namespace modDisplay.templates.vatlieu
{
    internal class Row : ARowObject
    {
        public Row(SpreadsheetGrid spreadsheetGrid, IWorksheet masksheet, IWorksheet workingsheet, string hangMucId, int id) : base(spreadsheetGrid, masksheet, workingsheet, hangMucId)
        {
            Id = id;
            colA = new ColA(this);
            colB = new ColB(this);
            colC = new ColC(this);
            colD = new ColD(this);
            colE = new ColE(this);
            colF = new ColF(this);
            colG = new ColG(this);
            colH = new ColH(this);
            colI = new ColI(this);
            colJ = new ColJ(this);
            colK = new ColK(this);
            colL = new ColL(this);
            colM = new ColM(this);  
            colN = new ColN(this);
            colO = new ColO(this);  
            colP = new ColP(this);
        }

        /// <summary>
        /// Số thứ tự
        /// </summary>
        public ColA colA;
        /// <summary>
        /// Mã vật liệu
        /// </summary>
        public ColB colB;
        /// <summary>
        /// Tên vật liệu
        /// </summary>
        public ColC colC;
        /// <summary>
        /// Đơn vị
        /// </summary>
        public ColD colD;
        /// <summary>
        /// Giá gốc
        /// </summary>
        public ColE colE;
        /// <summary>
        /// Giá TB
        /// </summary>
        public ColF colF;
        /// <summary>
        /// Hệ số
        /// </summary>
        public ColG colG;
        /// <summary>
        /// Giá TBxHS
        /// </summary>
        public ColH colH;
        /// <summary>
        /// Cước ô tô
        /// </summary>
        public ColI colI;
        /// <summary>
        /// Cước sông
        /// </summary>
        public ColJ colJ;
        /// <summary>
        /// Cước thủ công
        /// </summary>
        public ColK colK;
        /// <summary>
        /// Cước biển
        /// </summary>
        public ColL colL;
        /// <summary>
        /// Cước khác
        /// </summary>
        public ColM colM;
        /// <summary>
        /// Tổng cước
        /// </summary>
        public ColN colN;
        /// <summary>
        /// Giá hiện trường	
        /// </summary>
        public ColO colO;
        /// <summary>
        /// Ghi chú
        /// </summary>
        public ColP colP;
        public class ColA : ACol
        {
            public override string UniqueName { get { return "VatLieu_SoThuTu"; } }
            public override string Col { get { return "A"; } }
            public ColA(Row r) : base(r)
            {
            }

            /// <summary>
            /// Hiển thị số thứ tự
            /// </summary>
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColB : ACol
        {
            public override string UniqueName { get { return "VatLieu_MaVatLieu"; } }
            public override string Col { get { return "B"; } }
            public ColB(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColC : ACol
        {
            public override string UniqueName { get { return "VatLieu_TenVatLieu"; } }
            public override string Col { get { return "C"; } }
            public ColC(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColD : ACol
        {
            public override string UniqueName { get { return "VatLieu_DonVi"; } }
            public override string Col { get { return "D"; } }
            public ColD(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColE : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaGoc"; } }
            public override string Col { get { return "E"; } }
            public ColE(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColF : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaThongBao"; } }
            public override string Col { get { return "F"; } }
            public ColF(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColG : ACol
        {
            public override string UniqueName { get { return "VatLieu_HeSo"; } }
            public override string Col { get { return "G"; } }
            public ColG(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColH : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaTBxHS"; } }
            public override string Col { get { return "H"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColH(Row r) : base(r)
            {
            }
        }
        public class ColI : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocOto"; } }
            public override string Col { get { return "I"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColI(Row r) : base(r)
            {
            }
        }
        public class ColJ : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocSong"; } }
            public override string Col { get { return "J"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColJ(Row r) : base(r)
            {
            }
        }
        public class ColK : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocThuCong"; } }
            public override string Col { get { return "K"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColK(Row r) : base(r)
            {
            }
        }
        public class ColL : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocBien"; } }
            public override string Col { get { return "L"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColL(Row r) : base(r)
            {
            }
        }
        public class ColM : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocKhac"; } }
            public override string Col { get { return "M"; } }
            public ColM(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }
        public class ColN : ACol
        {
            public override string UniqueName { get { return "VatLieu_TongCuoc"; } }
            public override string Col { get { return "N"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColN(Row r) : base(r)
            {
            }
        }
        public class ColO : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaHienTruong"; } }
            public override string Col { get { return "O"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColO(Row r) : base(r)
            {
            }
        }
        public class ColP : ACol
        {
            public override string UniqueName { get { return "VatLieu_GhiChu"; } }
            public override string Col { get { return "P"; } }
            public ColP(Row r) : base(r)
            {
            }
            public override void Render()
            {
                // todo: bind data to working sheet
            }
        }

        internal void bind()
        {
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            colA.Render();
            colB.Render();
            colC.Render();
            colD.Render();
            colE.Render();
            colF.Render();
            colG.Render();
            colH.Render();
            colI.Render();
            colJ.Render();
            colK.Render();
            colL.Render();
            colM.Render();
            colN.Render();
            colO.Render();
            colP.Render();
        }
        public void AddSimpleData()
        {
            // Add data ở working sheet
            colB.Range.Text = "V01897";
            colC.Range.Text = "Cát vàng";
            colD.Range.Text = "m3";
            colG.Range.Number = 1;
            colE.Range.Number = 389809;
            colF.Range.Number = 389809;
            //colH.Render();
            //colI.Render();
            //colJ.Render();
            //colK.Render();
            //colL.Render();
            //colM.Render();
            //colN.Render();
            //colO.Render();
            //colP.Render();

            Display.ActiveMaskSheetDebug = Display.WorkSheetsDebug["Giá vật liệu"];
            //Display.ActiveGridDebug.SetCellValue(Display.ActiveMaskSheetDebug.Range[colB.RangeDisplay.AddressLocal], colB.Range.Text);
            //Display.ActiveGridDebug.SetCellValue(Display.ActiveMaskSheetDebug.Range[colC.RangeDisplay.AddressLocal], colC.Range.Text);
            //Display.ActiveGridDebug.SetCellValue(Display.ActiveMaskSheetDebug.Range[colD.RangeDisplay.AddressLocal], colD.Range.Text);
            //Display.ActiveGridDebug.SetCellValue(Display.ActiveMaskSheetDebug.Range[colG.RangeDisplay.AddressLocal], colG.Range.Number.ToString());
            //Display.ActiveGridDebug.SetCellValue(Display.ActiveMaskSheetDebug.Range[colE.RangeDisplay.AddressLocal], colE.Range.Number.ToString());
            //Display.ActiveGridDebug.SetCellValue(Display.ActiveMaskSheetDebug.Range[colF.RangeDisplay.AddressLocal], colF.Range.Number.ToString());

            // Hiển thị ra mask sheet
            //spreadsheetGrid.SetCellValue(colB.RangeDisplay, "V01897");
            //spreadsheetGrid.SetCellValue(colC.RangeDisplay, "Cát vàng");
            //spreadsheetGrid.SetCellValue(colD.RangeDisplay, "m3");
            //spreadsheetGrid.SetCellValue(colG.RangeDisplay, "1");
            //spreadsheetGrid.SetCellValue(colE.RangeDisplay, "389809");
            //spreadsheetGrid.SetCellValue(colF.RangeDisplay, "389809");

        }
    }
}

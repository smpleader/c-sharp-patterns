using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.IO.OpenXML.Schema;
using unvell.ReoGrid.Utility;
using Worksheet.modData.Memories.Pointer;
using Cell = unvell.ReoGrid.Cell;

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal class Row : ARowObject
    {
        public Row(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, int id) : base(spreadsheetGrid, worksheet)
        {
            Id = id;
        }
        public bool HaveInterpretiveFormula = false;

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public IRange A { get {return this.Cell("A");} }
        /// <summary>
        /// STT
        /// </summary>
        public IRange B { get { return this.Cell("B"); } }
        /// <summary>
        /// MSCV
        /// </summary>
        public IRange C { get { return this.Cell("C"); } }
        /// <summary>
        /// Tên công việc
        /// </summary>
        public IRange D { get { return this.Cell("D"); } }
        /// <summary>
        /// Đơn vị
        /// </summary>
        public IRange E { get { return this.Cell("E"); } }
        /// <summary>
        /// Tên CK
        /// </summary>
        public IRange F { get { return this.Cell("F"); } }
        /// <summary>
        /// Số CK
        /// </summary>
        public IRange G { get { return this.Cell("G"); } }
        /// <summary>
        /// Dài
        /// </summary>
        public IRange H { get { return this.Cell("H"); } }
        /// <summary>
        /// Rộng
        /// </summary>
        public IRange I { get { return this.Cell("I"); } }
        /// <summary>
        /// Cao
        /// </summary>
        public IRange J { get { return this.Cell("J"); } }
        /// <summary>
        /// HS phụ
        /// </summary>
        public IRange K { get { return this.Cell("K"); } }
        /// <summary>
        /// KL Phụ
        /// </summary>
        public IRange L { get { return this.Cell("L"); } }
        /// <summary>
        /// Khối lượng
        /// </summary>
        public IRange M { get { return this.Cell("M"); } }
        /// <summary>
        /// Đơn giá vật liệu
        /// </summary>
        public IRange N { get { return this.Cell("N"); } }
        /// <summary>
        /// Đơn giá vật liệu phụ
        /// </summary>
        public IRange O { get { return this.Cell("O"); } }
        /// <summary>
        /// Đơn giá nhân công
        /// </summary>
        public IRange P { get { return this.Cell("P"); } }
        /// <summary>
        /// Đơn giá máy
        /// </summary>
        public IRange Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Thành tiền vật liệu
        /// </summary>
        public IRange R { get { return this.Cell("R"); } }
        /// <summary>
        /// Thành tiền vật liệu phụ
        /// </summary>
        public IRange S { get { return this.Cell("S"); } }
        /// <summary>
        /// Thành tiền nhân công
        /// </summary>
        public IRange T { get { return this.Cell("T"); } }
        /// <summary>
        /// Thành tiền máy
        /// </summary>
        public IRange U { get { return this.Cell("U"); } }
        /// <summary>
        /// Hệ số điều chỉnh vật liệu
        /// </summary>
        public IRange V { get { return this.Cell("V"); } }
        /// <summary>
        /// Hệ số điều chỉnh nhân công
        /// </summary>
        public IRange W { get { return this.Cell("W"); } }
        /// <summary>
        /// Hệ số điều chỉnh máy
        /// </summary>
        public IRange X { get { return this.Cell("X"); } }
        /// <summary>
        /// Thông tin đơn giá
        /// </summary>
        public IRange Y { get { return this.Cell("Y"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu
        /// </summary>
        public IRange Z { get { return this.Cell("Z"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu phụ
        /// </summary>
        public IRange AA { get { return this.Cell("AA"); } }
        /// <summary>
        /// Tổng giá của tất cả các nhân công
        /// </summary>
        public IRange AB { get { return this.Cell("AB"); } }
        /// Tổng giá của tất cả các máy
        public IRange AC { get { return this.Cell("AC"); } }

        class ColM : ACol
        {
            public override string UniqueName { get { return "CongViec_KhoiLuong"; } }
            public override string Col { get { return "M"; } }
            public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
            public ColM(Row r) : base(r)
            {
            }
            public override void render()
            {
                var range = Row.worksheet.Range[Col + Row.Id];
                // xử lý công thức cho cột M
                if (((Row)Row).HaveInterpretiveFormula)
                {
                    Row.ws.SetCellValue(range, string.Format(modBL.Container.Get(UniqueName).formula(Params)));
                }
                else
                {
                    Row.ws.SetCellValue(range, Row.Cell("M").Value);
                }
            }
        }
        class ColN : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaVatLieu"; } }
            public override string Col { get { return "N"; } } 
            public override string  TongTienVatTu { get{ return ((Row)Row).Z.Value.ToString(); }}
            public ColN(Row r) : base(r)
            {
            }
        }
        class ColO : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaVatLieuPhu"; } }
            public override string Col { get { return "O"; } }
            public override string TongTienVatTu { get { return ((Row)Row).AA.Value.ToString(); } }
            public ColO(Row r) : base(r)
            {
            }
        }
        class ColP : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaNhanCong"; } }
            public override string Col { get { return "P"; } }
            public override string TongTienVatTu { get { return ((Row)Row).AB.Value.ToString(); } }
            public ColP(Row r) : base(r)
            {
            }
        }
        class ColQ : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaMay"; } }
            public override string Col { get { return "Q"; } }
            public override string TongTienVatTu { get { return ((Row)Row).AC.Value.ToString(); } }
            public ColQ(Row r) : base(r)
            {
            }
        }
        class ColR : ACol
        {
            public override string UniqueName { get { return "CongViec_ThanhTienVatLieu"; } }
            public override string Col { get { return "R"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColR(Row r) : base(r)
            {
            }
        }
        class ColS : ACol
        {
            public override string UniqueName { get { return "CongViec_ThanhTienVatLieuPhu"; } }
            public override string Col { get { return "S"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColS(Row r) : base(r)
            {
            }
        }
        class ColT : ACol
        {
            public override string UniqueName { get { return "CongViec_ThanhTienNhanCong"; } }
            public override string Col { get { return "T"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColT(Row r) : base(r)
            {
            }
        }
        class ColU : ACol
        {
            public override string UniqueName { get { return "CongViec_ThanhTienMay"; } }
            public override string Col { get { return "U"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColU(Row r) : base(r)
            {
            }
        }
        
        public void bind()
        {
            
        }
        public void render()
        {
            // xử lý công thức cho cột M
            ColM colM = new ColM(this);
            // xử lý công thức cho cột N, O, P, Q
            colM.render();
            ColN colN = new ColN(this);
            colN.render();
            ColO  colO = new ColO(this);
            colO.render();
            ColP colP = new ColP(this);
            colP.render();
            ColQ colQ = new ColQ(this);
            colQ.render();
            // xử lý công thức cho cột R, S, T, U
            ColR colR = new ColR(this);
            colR.render();
            ColS colS = new ColS(this);
            colS.render();
            ColT colT = new ColT(this);
            colT.render();
            ColU colU = new ColU(this);
            colU.render();
        }

        public void AddSimpleData()
        {
            ws.SetCellValue(C,"AG.11111");
            ws.SetCellValue(D, "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)");
            ws.SetCellValue(E, "m3");

            ws.SetCellValue(V, "1");
            ws.SetCellValue(W, "1");
            ws.SetCellValue(X, "1");

            ws.SetCellValue(Y, "DinhMuc_2021XD_D12");

            ws.SetCellValue(Z, "685204");
            ws.SetCellValue(AA, "0");
            ws.SetCellValue(AB, "288111");
            ws.SetCellValue(AC, "70230");

            // set màu chữ thành không màu
            IRange range = worksheet.Range[Z.AddressLocal + ":" + AC.AddressLocal];
            range.CellStyle.Font.Color = Syncfusion.XlsIO.ExcelKnownColors.White;
            ws.InvalidateCell(range.Row, range.Column);
            //ws.Refresh();
        }
    }
}

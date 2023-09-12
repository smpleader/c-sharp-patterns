using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;


namespace modDisplay.templates.tienluong.row
{
    public class Row : ARowObject
    {
        public Row(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, IWorksheet workingsheet, string hangMucId, int id) : base(spreadsheetGrid, worksheet, workingsheet, hangMucId)
        {
            Id = id;
            colM = new ColM(this);
            colN = new ColN(this);
            colP = new ColP(this);
            colO = new ColO(this);
            colQ = new ColQ(this);
            colR = new ColR(this);
            colS = new ColS(this);
            colT = new ColT(this);
            colU = new ColU(this);
        }
        public bool HaveInterpretiveFormula = false;
        public ColM colM { get; set; }
        public ColN colN { get; set; }
        public ColO colO { get; set; }
        public ColP colP { get; set; }
        public ColQ colQ { get; set; }
        public ColR colR { get; set; }
        public ColS colS { get; set; }
        public ColT colT { get; set; }
        public ColU colU { get; set; }
        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public IRange A { get { return this.Cell("A"); } }
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

        public class ColM : ACol
        {
            public override string UniqueName { get { return "CongViec_KhoiLuong"; } }
            public override string Col { get { return "M"; } }
            public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
            public ColM(Row r) : base(r)
            {
            }
            public override void Render()
            {
                var range = Row.masksheet.Range[Col + Row.Id];
                // xử lý công thức cho cột M
                if (((Row)Row).HaveInterpretiveFormula)
                {
                    BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
                    Row.spreadsheetGrid.SetCellValue(range, string.Format(modBLContainer.Get(UniqueName).formula(Params)));
                }
                else
                {
                    Row.spreadsheetGrid.SetCellValue(range, Row.Cell("M").Value);
                }
            }
        }
        public class ColN : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaVatLieu"; } }
            public override string Col { get { return "N"; } }
            public override string TongTienVatTu
            {
                get
                {
                    string valueZ = ((Row)Row).Z.Value;
                    if (string.IsNullOrWhiteSpace(valueZ)) return "0";
                    return ((Row)Row).Z.Value.ToString();
                }
            }
            public ColN(Row r) : base(r)
            {
            }
        }
        public class ColO : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaVatLieuPhu"; } }
            public override string Col { get { return "O"; } }
            public override string TongTienVatTu
            {
                get
                {
                    string valueAA = ((Row)Row).AA.Value;
                    if (string.IsNullOrWhiteSpace(valueAA)) return "0";
                    return ((Row)Row).AA.Value.ToString();
                }
            }
            public ColO(Row r) : base(r)
            {
            }
        }
        public class ColP : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaNhanCong"; } }
            public override string Col { get { return "P"; } }
            public override string TongTienVatTu
            {
                get
                {
                    string valueAB = ((Row)Row).AB.Value;
                    if (string.IsNullOrWhiteSpace(valueAB)) return "0";
                    return ((Row)Row).AB.Value.ToString();
                }
            }
            public ColP(Row r) : base(r)
            {
            }
        }
        public class ColQ : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaMay"; } }
            public override string Col { get { return "Q"; } }
            public override string TongTienVatTu
            {
                get
                {
                    string valueAC = ((Row)Row).AC.Value;
                    if (string.IsNullOrWhiteSpace(valueAC)) return "0";
                    return ((Row)Row).AC.Value.ToString();
                }
            }
            public ColQ(Row r) : base(r)
            {
            }
        }
        public class ColR : ACol
        {
            public override string UniqueName { get { return "CongViec_ThanhTienVatLieu"; } }
            public override string Col { get { return "R"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColR(Row r) : base(r)
            {
            }
        }
        public class ColS : ACol
        {
            public override string UniqueName { get { return "CongViec_ThanhTienVatLieuPhu"; } }
            public override string Col { get { return "S"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColS(Row r) : base(r)
            {
            }
        }
        public class ColT : ACol
        {
            public override string UniqueName { get { return "CongViec_ThanhTienNhanCong"; } }
            public override string Col { get { return "T"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColT(Row r) : base(r)
            {
            }
        }
        public class ColU : ACol
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
            colM.Render();
            // xử lý công thức cho cột N, O, P, Q
            colN.Render();
            colO.Render();
            colP.Render();
            colQ.Render();
            // xử lý công thức cho cột R, S, T, U
            colR.Render();
            colS.Render();
            colT.Render();
            colU.Render();
        }

        public void AddSimpleData()
        {
            spreadsheetGrid.SetCellValue(C, "AG.11111");
            spreadsheetGrid.SetCellValue(D, "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)");
            spreadsheetGrid.SetCellValue(E, "m3");

            spreadsheetGrid.SetCellValue(V, "1");
            spreadsheetGrid.SetCellValue(W, "1");
            spreadsheetGrid.SetCellValue(X, "1");

            spreadsheetGrid.SetCellValue(Y, "DinhMuc_2021XD_D12");

            spreadsheetGrid.SetCellValue(Z, "685204");
            spreadsheetGrid.SetCellValue(AA, "0");
            spreadsheetGrid.SetCellValue(AB, "288111");
            spreadsheetGrid.SetCellValue(AC, "70230");

            // set màu chữ thành không màu
            IRange range = masksheet.Range[Z.AddressLocal + ":" + AC.AddressLocal];
            range.CellStyle.Font.Color = Syncfusion.XlsIO.ExcelKnownColors.White;
        }
    }
}

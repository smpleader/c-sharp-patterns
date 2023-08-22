using Microsoft.Office.Interop.Excel;
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
        public Row(unvell.ReoGrid.Worksheet worksheet, int id)
        {
            ws = worksheet;
            Id = id;
        }
        public bool HaveInterpretiveFormula = false;

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public Cell A { get {return this.Cell("A");} }
        /// <summary>
        /// STT
        /// </summary>
        public Cell B { get { return this.Cell("B"); } }
        /// <summary>
        /// MSCV
        /// </summary>
        public Cell C { get { return this.Cell("C"); } }
        /// <summary>
        /// Tên công việc
        /// </summary>
        public Cell D { get { return this.Cell("D"); } }
        /// <summary>
        /// Đơn vị
        /// </summary>
        public Cell E { get { return this.Cell("E"); } }
        /// <summary>
        /// Tên CK
        /// </summary>
        public Cell F { get { return this.Cell("F"); } }
        /// <summary>
        /// Số CK
        /// </summary>
        public Cell G { get { return this.Cell("G"); } }
        /// <summary>
        /// Dài
        /// </summary>
        public Cell H { get { return this.Cell("H"); } }
        /// <summary>
        /// Rộng
        /// </summary>
        public Cell I { get { return this.Cell("I"); } }
        /// <summary>
        /// Cao
        /// </summary>
        public Cell J { get { return this.Cell("J"); } }
        /// <summary>
        /// HS phụ
        /// </summary>
        public Cell K { get { return this.Cell("K"); } }
        /// <summary>
        /// KL Phụ
        /// </summary>
        public Cell L { get { return this.Cell("L"); } }
        /// <summary>
        /// Khối lượng
        /// </summary>
        public Cell M { get { return this.Cell("M"); } }
        /// <summary>
        /// Đơn giá vật liệu
        /// </summary>
        public Cell N { get { return this.Cell("N"); } }
        /// <summary>
        /// Đơn giá vật liệu phụ
        /// </summary>
        public Cell O { get { return this.Cell("O"); } }
        /// <summary>
        /// Đơn giá nhân công
        /// </summary>
        public Cell P { get { return this.Cell("P"); } }
        /// <summary>
        /// Đơn giá máy
        /// </summary>
        public Cell Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Thành tiền vật liệu
        /// </summary>
        public Cell R { get { return this.Cell("R"); } }
        /// <summary>
        /// Thành tiền vật liệu phụ
        /// </summary>
        public Cell S { get { return this.Cell("S"); } }
        /// <summary>
        /// Thành tiền nhân công
        /// </summary>
        public Cell T { get { return this.Cell("T"); } }
        /// <summary>
        /// Thành tiền máy
        /// </summary>
        public Cell U { get { return this.Cell("U"); } }
        /// <summary>
        /// Hệ số điều chỉnh vật liệu
        /// </summary>
        public Cell V { get { return this.Cell("V"); } }
        /// <summary>
        /// Hệ số điều chỉnh nhân công
        /// </summary>
        public Cell W { get { return this.Cell("W"); } }
        /// <summary>
        /// Hệ số điều chỉnh máy
        /// </summary>
        public Cell X { get { return this.Cell("X"); } }
        /// <summary>
        /// Thông tin đơn giá
        /// </summary>
        public Cell Y { get { return this.Cell("Y"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu
        /// </summary>
        public Cell Z { get { return this.Cell("Z"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu phụ
        /// </summary>
        public Cell AA { get { return this.Cell("AA"); } }
        /// <summary>
        /// Tổng giá của tất cả các nhân công
        /// </summary>
        public Cell AB { get { return this.Cell("AB"); } }
        /// Tổng giá của tất cả các máy
        public Cell AC { get { return this.Cell("AC"); } }

        class ACol
        {
            public ACol(Row r)
            {
                Row = r;
            }
            public Row Row { get; set; }
            public virtual string UniqueName { get { return ""; } }
            public virtual string Col { get { return "A"; } }
            public virtual string TongTienVatTu { get { return ""; } }
            public virtual string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }
            public virtual void render()
            {
                Row.ws[Col + Row.Id] = string.Format(modBL.Container.Get(UniqueName).formula(Params));
            }
        }
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
                // xử lý công thức cho cột M
                if (Row.HaveInterpretiveFormula)
                {
                    Row.ws[Col + Row.Id] = string.Format(modBL.Container.Get(UniqueName).formula(Params));
                }
                else
                {
                    Row.ws[Col + Row.Id] = Row.Cell("M").GetData<string>();
                }
            }
        }
        class ColN : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaVatLieu"; } }
            public override string Col { get { return "N"; } } 
            public override string  TongTienVatTu { get{ return Row.Z.GetData<decimal>().ToString(); }}
            public ColN(Row r) : base(r)
            {
            }
        }
        class ColO : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaVatLieuPhu"; } }
            public override string Col { get { return "O"; } }
            public override string TongTienVatTu { get { return Row.AA.GetData<decimal>().ToString(); } }
            public ColO(Row r) : base(r)
            {
            }
        }
        class ColP : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaNhanCong"; } }
            public override string Col { get { return "P"; } }
            public override string TongTienVatTu { get { return Row.AB.GetData<decimal>().ToString(); } }
            public ColP(Row r) : base(r)
            {
            }
        }
        class ColQ : ACol
        {
            public override string UniqueName { get { return "CongViec_DonGiaMay"; } }
            public override string Col { get { return "Q"; } }
            public override string TongTienVatTu { get { return Row.AC.GetData<decimal>().ToString(); } }
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
            C.Data = "AG.11111";
            D.Data = "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)";
            E.Data = "m3";

            V.Data = 1;
            W.Data = 1;
            X.Data = 1;

            Y.Data = "DinhMuc_2021XD_D12";

            Z.Data = 685204;
            AA.Data = 0;
            AB.Data = 288111;
            AC.Data = 70230;

            // set màu chữ thành không màu
            ws.SetRangeStyles(Z.Position.ToAddress() + ":" + AC.Position.ToAddress(), new WorksheetRangeStyle()
            {
                Flag = PlainStyleFlag.TextColor,
                TextColor = Color.Transparent,
            });
        }
    }
}

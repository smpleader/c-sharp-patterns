using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modDisplay.templates.tienluong.row;

namespace Worksheet.modDisplay.templates.cuocoto.loaiphuongtien.row
{
    internal class Row : ARowObject
    {
        public Row(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, int id) : base(spreadsheetGrid, worksheet)
        {
            Id = id;
        }

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

        class ColL : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaTBxHS"; } }
            public override string Col { get { return "L"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColL(Row r) : base(r)
            {
            }
        }
        class ColV : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaHienTruong"; } }
            public override string Col { get { return "V"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColV(Row r) : base(r)
            {
            }
        }
        class ColM : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocOto"; } }
            public override string Col { get { return "M"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColM(Row r) : base(r)
            {
            }
        }
        class ColO : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocSong"; } }
            public override string Col { get { return "O"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColO(Row r) : base(r)
            {
            }
        }
        class ColP : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocThuCong"; } }
            public override string Col { get { return "P"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColP(Row r) : base(r)
            {
            }
        }
        class ColS : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocBien"; } }
            public override string Col { get { return "S"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColS(Row r) : base(r)
            {
            }
        }
        class ColU : ACol
        {
            public override string UniqueName { get { return "VatLieu_TongCuoc"; } }
            public override string Col { get { return "U"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColU(Row r) : base(r)
            {
            }
        }
        class ColL : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaTBxHS"; } }
            public override string Col { get { return "L"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColL(Row r) : base(r)
            {
            }
        }
        internal void bind()
        {
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            ColM colM = new ColM(this);
            colM.render();
            ColO colO = new ColO(this);
            colO.render();
            ColP colP = new ColP(this);
            colP.render();
            ColS colS = new ColS(this);
            colS.render();
            ColU colU = new ColU(this);
            colU.render();
            ColV colV = new ColV(this);
            colV.render();
            ColL colL = new ColL(this);
            colL.render();
        }
        public void AddSimpleData()
        {
            spreadsheetGrid.SetCellValue(C, "V01897");
            spreadsheetGrid.SetCellValue(E, "Cát vàng");
            spreadsheetGrid.SetCellValue(F, "m3");

            spreadsheetGrid.SetCellValue(K, "1");
            spreadsheetGrid.SetCellValue(G, "389809");
            spreadsheetGrid.SetCellValue(J, "389809");

        }
    }
}

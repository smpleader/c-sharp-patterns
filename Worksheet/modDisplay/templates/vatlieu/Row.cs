using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modDisplay.templates.tienluong.row;

namespace Worksheet.modDisplay.templates.vatlieu
{
    internal class Row : ARowObject
    {
        public Row(unvell.ReoGrid.Worksheet worksheet ,int id)
        {
            ws = worksheet;
            Id = id;
        }

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public Cell A { get { return this.Cell("A"); } }
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
        class ColV : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaHienTruong"; } }
            public override string Col { get { return "V"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString()}; } }
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
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColU(Row r) : base(r)
            {
            }
        }
        class ColL : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaTBxHS"; } }
            public override string Col { get { return "L"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
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
            C.Data = "V01897";
            E.Data = "Cát vàng";
            F.Data = "m3";
            K.Data = 1;

            G.Data = 389809;
            J.Data = 389809;
        }
    }
}

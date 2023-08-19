using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.modDisplay.templates.dinhmucvatlieu.row
{
    internal class AdditionalRow : ARowObject
    {
        public AdditionalRow(unvell.ReoGrid.Worksheet worksheet, int id)
        {   
            ws = worksheet;
            Id = id;
        }
        /// <summary>
        /// STT
        /// </summary>
        public Cell A { get { return GetCell("A"); } }
        /// <summary>
        /// Mã VL
        /// </summary>
        public Cell B { get { return GetCell("B"); } }
        /// <summary>
        /// Tên vật liệu
        /// </summary>
        public Cell C { get { return GetCell("C"); } }
        /// <summary>
        /// Đơn vị
        /// </summary>
        public Cell D { get { return GetCell("D"); } }
        /// <summary>
        /// Hao phí
        /// </summary>
        public Cell E { get { return GetCell("E"); } }
        /// <summary>
        /// Giá gốc
        /// </summary>
        public Cell F { get { return GetCell("F"); } }
        /// <summary>
        /// Giá TB
        /// </summary>
        public Cell G { get { return GetCell("G"); } }
        /// <summary>
        /// Giá HT
        /// </summary>
        public Cell H { get { return GetCell("H"); } }
        /// <summary>
        /// Loại VL
        /// </summary>
        public Cell I { get { return GetCell("I"); } }
        /// <summary>
        /// HP khác
        /// </summary>
        public Cell J { get { return GetCell("J"); } }

        public Cell K { get { return GetCell("K"); } }
        /// <summary>
        /// Hao phí gốc
        /// </summary>
        public Cell L { get { return GetCell("L"); } }

        public void bind()
        {

        }

        public void render()
        {

        }

        public void AddSimpleData()
        {
            A.Data = "1";
            // Mã VL
            B.Data = "C2221";
            // Tên vật liệu
            C.Data = "Vữa bê tông M100, XM PCB30, đá 1x2, độ sụt 2÷4cm";
            // đơn vị
            D.Data = "m3";
            // hao phí
            E.Data = 1.015;
            F.Data = 671718.771;
            G.Data = 671718.771;
            H.Data = 671718.771;
            I.Data = "C";
            J.Data = 0.5;
            K.Data = "";
            L.Data = 1.015;

            // set màu chữ thành không màu
            ws.SetRangeStyles(K.Position.ToAddress() + ":" + L.Position.ToAddress(), new WorksheetRangeStyle()
            {
                Flag = PlainStyleFlag.TextColor,
                TextColor = Color.Transparent,
            });
        }
    }
}

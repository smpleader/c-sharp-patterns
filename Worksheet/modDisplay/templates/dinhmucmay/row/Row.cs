using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.modDisplay.templates.dinhmucmay.row
{
    internal class Row : ARowObject
    {
        public Row(unvell.ReoGrid.Worksheet worksheet, int id)
        {
            ws = worksheet;
            Id = id;
        }
        public bool HaveSubRow = false;
        /// <summary>
        /// STT
        /// </summary>
        public Cell A { get { return GetCell("A"); } }
        /// <summary>
        /// Mã máy
        /// </summary>
        public Cell B { get { return GetCell("B"); } }
        /// <summary>
        /// Tên máy
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
        /// HP khác
        /// </summary>
        public Cell I { get { return GetCell("I"); } }
        /// <summary>
        /// 
        /// </summary>
        public Cell J { get { return GetCell("J"); } }
        /// <summary>
        /// Hao phí gốc
        /// </summary>
        public Cell K { get { return GetCell("K"); } }
       
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
            B.Data = "M1419";
            // Tên vật liệu
            C.Data = "Máy trộn bê tông 250 lít";
            // đơn vị
            D.Data = "ca";
            // hao phí
            E.Data = 0.095;
            F.Data = 284198;
            G.Data = 284198;
            H.Data = 284198;
            I.Data = "";
            J.Data = "";
            K.Data = 0.095;

            // set màu chữ thành không màu
            ws.SetRangeStyles(J.Position.ToAddress() + ":" + K.Position.ToAddress(), new WorksheetRangeStyle()
            {
                Flag = PlainStyleFlag.TextColor,
                TextColor = Color.Transparent,
            });
        }
    }
}

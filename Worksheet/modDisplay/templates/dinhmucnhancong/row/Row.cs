using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.modDisplay.templates.dinhmucnhancong.row
{
    internal class Row : ARowObject
    {
        public Row(unvell.ReoGrid.Worksheet worksheet, int id)
        {
            ws = worksheet;
            Id = id;
        }
        /// <summary>
        /// STT
        /// </summary>
        public Cell A { get { return GetCell("A"); } }
        /// <summary>
        /// Mã NC
        /// </summary>
        public Cell B { get { return GetCell("B"); } }
        /// <summary>
        /// Tên nhân công
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
      
        public Cell I { get { return GetCell("I"); } }
        /// <summary>
        /// HP gốc
        /// </summary>
        public Cell J { get { return GetCell("J"); } }

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
            B.Data = "N2307";
            // Tên vật liệu
            C.Data = "Nhân công bậc 3,0/7 - Nhóm 2";
            // đơn vị
            D.Data = "công";
            // hao phí
            E.Data = 1.37;
            F.Data = 210300;
            G.Data = 210300;
            H.Data = 210300;
            I.Data = "";
            J.Data = 1.37;

            // set màu chữ thành không màu
            ws.SetRangeStyles(I.Position.ToAddress() + ":" + J.Position.ToAddress(), new WorksheetRangeStyle()
            {
                Flag = PlainStyleFlag.TextColor,
                TextColor = Color.Transparent,
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.Utility;

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal class Footer : ARowObject
    {
        Dictionary<string, string> aliasUniqueName = new Dictionary<string, string>() {
            { "R", "CongViec_ThanhTienVatLieu" },
            { "S", "CongViec_ThanhTienVatLieuPhu" },
            { "T", "CongViec_ThanhTienNhanCong" },
            { "U", "CongViec_ThanhTienMay" },
        };
        public Footer(unvell.ReoGrid.Worksheet worksheet)
        {
            ws = worksheet;
            Id = 16;
            start = 6;
        }
        /// <summary>
        /// Tổng hạng mục
        /// </summary>
        public Cell A { get { return GetCell("A"); } }
       
        public Cell R { get { return GetCell("R"); } }
       
        public Cell S { get { return GetCell("S"); } }
        
        public Cell T { get { return GetCell("T"); } }
        
        public Cell U { get { return GetCell("U"); } }

        /// <summary>
        /// Tổng thành tiền vật liệu
        /// </summary>
        public decimal TongThanhTienVatLieu
        {
            get
            {
                return R.GetData<decimal>();
            }
        }

        /// <summary>
        /// Tổng thành tiền vật liệu phụ
        /// </summary>
        public decimal TongThanhTienVatLieuPhu
        {
            get
            {
                return S.GetData<decimal>();
            }
        }

        /// <summary>
        /// Tổng thành tiền nhân công
        /// </summary>
        public decimal TongThanhTienNhanCong
        {
            get
            {
                return T.GetData<decimal>();
            }
        }

        /// <summary>
        /// Tổng thành tiền máy
        /// </summary>
        public decimal TongThanhTienMay
        {
            get
            {
                return U.GetData<decimal>();
            }
        }
        
        public void bind()
        {
            Id = this.FindIndexRowFooter(ws, start);
            end = Id - 1;
        }

        public void render()
        {
            // todo: render lại khi thêm hoặc xóa dòng
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            foreach (string colName in aliasUniqueName.Keys)
            {
                string formula = string.Format(modBL.Container.Get(aliasUniqueName[colName]).formula(parameters));
                ws[colName + Id] = formula;
            }
        }
    }
}

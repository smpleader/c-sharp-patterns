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
using Worksheet.modDisplay.templates.tienluong.row;
using Cell = unvell.ReoGrid.Cell;

namespace Worksheet.modDisplay.templates.cuocoto.tongculy.row
{
    internal class AdditionalRow : ARowObject
    {
        public AdditionalRow(SpreadsheetGrid spreadsheetGrid,IWorksheet worksheet , int id) : base(spreadsheetGrid,worksheet)
        {
            Id = id;
        }
        /// <summary>
        /// Nguồn mua
        /// </summary>
        public IRange H { get { return this.Cell("H"); } }
        /// <summary>
        /// Phương tiện
        /// </summary>
        public IRange I { get { return this.Cell("I"); } }
        /// <summary>
        /// Hệ số phương tiện
        /// </summary>
        public IRange J { get { return this.Cell("J"); } }
        /// <summary>
        /// Loại đường
        /// </summary>
        public IRange K { get { return this.Cell("K"); } }
        /// <summary>
        /// Cự ly (km)
        /// </summary>
        public IRange L { get { return this.Cell("L"); } }
        /// <summary>
        /// Tổng cự ly
        /// </summary>
        public IRange M { get { return this.Cell("M"); } }
        /// <summary>
        /// Cước cơ bản
        /// </summary>
        public IRange N { get { return this.Cell("N"); } }
        /// <summary>
        /// Cước sau thuế
        /// </summary>
        public IRange O { get { return this.Cell("O"); } }
        /// <summary>
        /// Trước thuế
        /// </summary>
        public IRange P { get { return this.Cell("P"); } }
        /// <summary>
        /// Định mức bốc dỡ
        /// </summary>
        public IRange Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Cước nâng hạ
        /// </summary>
        public IRange R { get { return this.Cell("R"); } }
        /// <summary>
        /// Thành tiền vật
        /// </summary>
        public IRange S { get { return this.Cell("S"); } }
        /// <summary>
        /// Giá TB
        /// </summary>
        public IRange T { get { return this.Cell("T"); } }
        /// <summary>
        /// Định mức hao hụt
        /// </summary>
        public IRange U { get { return this.Cell("U"); } }
        /// <summary>
        /// Thành tiền hao hụt
        /// </summary>
        public IRange V { get { return this.Cell("V"); } }
        /// <summary>
        /// Chi phí khác
        /// </summary>
        public IRange W { get { return this.Cell("W"); } }

        /// <summary>
        /// Lấy công thức cho các cột R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public string GetFormula(string col)
        {
            string[] parameters = new string[1] { Id.ToString() };
            return string.Format(modBL.Container.Get("CongViec_KhoiLuongPhu").formula(parameters));
        }
        public void bind()
        {
            string A = worksheet.Range["A" + Id].Value;
            if (string.IsNullOrWhiteSpace(A))
            {

            }
        }
        
        internal void render()
        {
            
        }
    }
}

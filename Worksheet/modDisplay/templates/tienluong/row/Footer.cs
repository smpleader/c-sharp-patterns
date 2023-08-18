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

        /// <summary>
        /// Lấy công thức cho các cột  R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public override string GetFormula(string col)
        {
            string uniqueName = "";
            string formula;
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            switch (col)
            {
                case "R":
                    uniqueName = "CongViec_ThanhTienVatLieu";
                    break;
                case "S":
                    uniqueName = "CongViec_ThanhTienVatLieuPhu";
                    break;
                case "T":
                    uniqueName = "CongViec_ThanhTienNhanCong";
                    break;
                case "U":
                    uniqueName = "CongViec_ThanhTienMay";
                    break;
                default: break;
            }
            formula = string.Format(modBL.Container.Get(uniqueName).fml(parameters));
            return formula;
        }
        public void bind()
        {
            for (int indexRow = start; indexRow <= ws.MaxContentRow; indexRow++)
            {
                // Tìm dòng cuối của template
                if (!IsCellEmptyOrNull(ws, "A" + indexRow))
                {
                    if (CellUtility.ConvertData<string>(ws["A" + indexRow]) == "CỘNG HẠNG MỤC")
                    {
                        Id = indexRow;
                        end = indexRow - 1;
                    }
                }
            }
        }

        public void render()
        {
            // todo: render lại khi thêm hoặc xóa dòng
            List<string> colsHaveFormula = new List<string>() { "R", "S", "T", "U" };
            foreach (string col in colsHaveFormula)
            {
                ws[col + Id] = GetFormula(col);
            }
        }

        /// <summary>
        /// Kiểm tra cell có null hoặc empty không
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="cellAddress"></param>
        /// <returns></returns>
        static bool IsCellEmptyOrNull(unvell.ReoGrid.Worksheet worksheet, string cellAddress)
        {
            var cell = CellUtility.ConvertData<string>(worksheet[cellAddress]);
            if (cell == null || cell == "")
            {
                return true;
            }
            return false;
        }
    }
}

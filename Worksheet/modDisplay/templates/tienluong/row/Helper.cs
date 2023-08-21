using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal static class Helper
    {
        /// <summary>
        /// Tìm index row của footer của template vật liệu
        /// </summary>
        /// <param name="footer"></param>
        /// <param name="ws">Template</param>
        /// <param name="start">Chỉ số dòng bắt đầu tìm</param>
        /// <returns></returns>
        public static int FindIndexRowFooter(this Footer footer, unvell.ReoGrid.Worksheet ws, int start)
        {
            for (int indexRow = start; indexRow <= ws.MaxContentRow; indexRow++)
            {
                // Tìm dòng cuối của template
                if (!Util.CellUtility.IsCellEmptyOrNull(ws, "A" + indexRow))
                {
                    if (CellUtility.ConvertData<string>(ws["A" + indexRow]) == "CỘNG HẠNG MỤC")
                    {
                        return indexRow;
                    }
                }
            }
            return -1;
        }
        public static bool IsRowObject(unvell.ReoGrid.Worksheet ws,int indexRow)
        {
            if (!ws.IsMergedCell("B" + indexRow))
            {
                string C = CellUtility.ConvertData<string>(ws["C" + indexRow]);
                if (C != null && !C.StartsWith("*"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsGroupObject(unvell.ReoGrid.Worksheet ws, int indexRow)
        {
            if (ws.IsMergedCell("B" + indexRow))
            {
                return true;
            }
            else
            {
                string C = CellUtility.ConvertData<string>(ws["C" + indexRow]);
                if (C != null && C.StartsWith("*"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsAdditionalRowObject(unvell.ReoGrid.Worksheet ws, int indexRow)
        {
            if (!ws.IsMergedCell("B" + indexRow))
            {
                if (Util.CellUtility.IsCellEmptyOrNull(ws, "B" + indexRow) && Util.CellUtility.IsCellEmptyOrNull(ws, "C" + indexRow))
                {
                    // check công thức diễn giải khi nhập vào
                    if (!Util.CellUtility.IsCellEmptyOrNull(ws, "D" + indexRow) || !Util.CellUtility.IsCellEmptyOrNull(ws, "L" + indexRow))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static unvell.ReoGrid.Cell Cell(this ARowObject aRowObject, string colName)
        {
            unvell.ReoGrid.Cell cell = aRowObject.ws.Cells[colName + aRowObject.Id];
            return cell;
        }

    }
}

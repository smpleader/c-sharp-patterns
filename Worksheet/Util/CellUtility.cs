using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;

namespace Worksheet.Util
{
    internal class CellUtility
    {
        /// <summary>
        /// Kiểm tra cell có null hoặc empty không
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="cellAddress"></param>
        /// <returns></returns>
        public static bool IsCellEmptyOrNull(unvell.ReoGrid.Worksheet worksheet, string cellAddress)
        {
            var cell = unvell.ReoGrid.Utility.CellUtility.ConvertData<string>(worksheet[cellAddress]);
            if (cell == null || cell == "")
            {
                return true;
            }
            return false;
        }
    }
}

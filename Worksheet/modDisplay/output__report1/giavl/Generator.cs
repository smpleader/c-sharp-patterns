using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.output__report1.giavl
{
    /* Giá vật liệu */

    internal class Generator //: ISheet
    {
        string startCol;
        string endCol;
        string startRow;
        string endRow;
        string dataId; // key to archive data from modData for this sheet

        string startCell { get { return startCol + startRow; } }
        string endCell { get { return endCol + endRow; } }

        int stt { get; set; }
        int A { get { return stt; } set { stt = value; } }
         
        public void setRow(object data)
        {

            // fill data to row

        }

    }
}

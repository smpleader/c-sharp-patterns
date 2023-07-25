using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.Tpl.report1
{
    /* Giá vật liệu */

    internal class giavl: ITplFile
    {
        string startCol;
        string endCol;
        string startRow;
        string endRow;
        string dataId; // key to archive data from modData for this sheet

        string startCell { get {  return startCol + startRow; } }
        string endCell { get { return endCol + endRow; } }

        int stt { get; set; }
        int A { get { return stt; } set { stt = value; } }

        public IObject getRow() {

            return new IObject();
            // return 
        }
        public void setRow(object data) {
            
            // fill data to row
        
        }

    }
}

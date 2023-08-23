using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL
{
    /*
     đại diện cho 1 ô có thể thay thế cách tính và giá trị, 
    dựa theo biểu mẫu cũng như phương pháp tính
     */
    interface ICell
    {
        string CName { get; }
        string UName { get;}
        Option Option { get; set; }

        // return forumalation of cell
        string formula(string[] args);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.Util;
using Worksheet.Util.Drivers;

namespace Worksheet.MVC.Models
{
    internal class DemoM
    {
        public List<string> ComboboxTemplateList(string folder)
        {
            List<string> list = AFile.GetFiles(AppConst.templateFolder + "/" + folder, new List<string> { "*.xlsx"}); // , "*.csv", "*.ods", "*.xls" 
            return list;
        }
    }
}

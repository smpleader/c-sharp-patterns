using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.Util;
using Worksheet.modData.Drivers;

namespace Worksheet.MVC.Models
{
    internal class DemoM
    {
        public List<string> ComboboxTemplateList(string path)
        {
            List<string> list = AFile.GetFiles(path, new List<string> { "*.xlsx"}); // , "*.csv", "*.ods", "*.xls" 
            return list;
        }


    }
}

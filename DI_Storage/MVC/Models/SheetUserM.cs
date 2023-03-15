using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_Storage.Drivers;
using DI_Storage.Util;

namespace DI_Storage.MVC.Models
{
    internal class SheetUserM
    {
        public List<string> ComboboxList()
        {
            List<string> list = SheetFile.GetFiles(AppConst.dataFolder);
            return list;
        }
    }
}

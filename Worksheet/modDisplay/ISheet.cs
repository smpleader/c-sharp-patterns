using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay
{
    interface ISheet
    {
        string Name { get; }
        void init(string tabName);
        void loadData();
        void beforeSave();
        void afterSave();
        void selectCell();
        void afterCellInput();
    }
}

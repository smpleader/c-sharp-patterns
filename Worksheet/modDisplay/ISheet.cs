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
        string head(string name);
        string foot(string name);
        Dictionary<string, ARow> content(string name);
    }
}

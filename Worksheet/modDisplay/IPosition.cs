using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay
{
    internal interface IPosition
    {
        string Name { get; }
        int Id { get; set; }
        void bind();
        void render();
    }
}

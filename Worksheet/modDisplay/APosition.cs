using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay
{
    internal class APosition : IPosition
    {
        public virtual string Name { get { return "--"; } }
        public SpreadsheetGrid ws { get; set; }
        public IWorksheet worksheet { get; set; }

        public int Id { get; set; }

        public virtual void bind(){}

        public virtual void render(){}
        public APosition(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet)
        {
            ws = spreadsheetGrid;
            this.worksheet = worksheet;
        }
    }
}

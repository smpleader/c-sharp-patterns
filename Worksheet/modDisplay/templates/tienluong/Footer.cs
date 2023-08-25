using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;
using FooterRow = Worksheet.modDisplay.templates.tienluong.row.Footer;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Footer : APosition
    {
        FooterRow footer;

        public Footer(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet) : base(spreadsheetGrid, worksheet)
        {
            Id = 16;
        }
       
        public override void bind()
        {
            footer = new FooterRow(spreadsheetGrid, worksheet);
            footer.bind();
            Id = footer.Id;
        }
        public override void render()
        {
            footer.render();
        }
    }
}

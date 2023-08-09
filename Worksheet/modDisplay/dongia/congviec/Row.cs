using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modData.Memories.Record;

namespace Worksheet.modDisplay.dongia.congviec
{
    internal class Row : ARowObject
    {
        //public Row(VatLieu r) { ColNum = r.ColNum; ColText = r.ColText; }
        public Row(int id) 
        { 
            Id = id;
        }

        Button btnVL = new Button("VL");
        Button btnNC = new Button("NC");
        Button btnCM = new Button("CM");

        public string A { get { return txt("stt"); } set { txt("stt", value); } }
        public string B { get { return txt("ma"); } set { txt("ma", value); } }
        public Button C { get { return btnVL; } }
        public Button D { get { return btnNC; } }
        public Button E { get { return btnCM; } } 

        public void bind(unvell.ReoGrid.Worksheet data)
        {
            // TODO: consider a link to cell address, not a data hold
            // Current status: map column to BL/cell
          //  A = data.Cells["A"+Id].Data.ToString();
           // B = data.Cells["B"+Id].Data.ToString();

           // modData.Memories.Models.CongViec.capnhat(this);
        }

    }
}


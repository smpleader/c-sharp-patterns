using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modData.Memories.Record;

namespace Worksheet.modDisplay.dongia.congviec_chitiet
{
    internal class Row : ARowObject
    {
        //public Row(VatLieu r) { ColNum = r.ColNum; ColText = r.ColText; }
        public Row(int id) 
        { 
            Id = id;
        } 

        public string A { get { return txt("stt"); } set { txt("stt", value); } }
        public string B { get { return txt("ma"); } set { txt("ma", value); } }
        public string C { get { return ""; } }
        public string D { get { return ""; } }
        public string E { get { return ""; } } 

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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        Button btnVL = new Button("V");
        Button btnNC = new Button("");
        Button btnCM = new Button("");

        public string A { get { return txt("stt"); } set { txt("stt", value); } }
        public string B { get { return txt("ma"); } set { txt("ma", value); } }
        public Button C { get { return btnVL; } }
        public Button D { get { return btnNC; } }
        public Button E { get { return btnCM; } } 

    }
}


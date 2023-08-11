using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.templates.vatlieu
{
    internal class Row : ARowObject
    {
        public Row(int id)
        {
            Id = id;
        }

        public string A { get { return txt("stt"); } set { txt("stt", value); } }
        public string B { get { return txt("maHieu"); } set { txt("maHieu", value); } }
        public string C { get { return txt("tenVatLieu"); } set { txt("tenVatLieu", value); } }
        public string D { get { return txt("donVi"); } set { txt("donVi", value); } }
        public string E { get { return txt("giaGoc"); } set { txt("giaGoc", value); } }
        public string F { get { return txt("giaTB"); } set { txt("giaTB", value); } }
        public string G { get { return txt("heSo"); } set { txt("heSo", value); } }
        public string H { get { return txt("giaTBxHS"); } set { txt("giaTBxHS", value); } }
        public string I { get { return txt("cuocOto"); } set { txt("cuocOto", value); } }
        public string J { get { return txt("cuocSong"); } set { txt("cuocSong", value); } }
        public string K { get { return txt("cuocTC"); } set { txt("cuocTC", value); } }
        public string L { get { return txt("cuocBien"); } set { txt("cuocBien", value); } }
        public string M { get { return txt("cuocKhac"); } set { txt("cuocKhac", value); } }
        public string N { get { return txt("tongCuoc"); } set { txt("tongCuoc", value); } }
        public string O { get { return txt("giaHT"); } set { txt("giaHT", value); } }
        public string P { get { return txt("ghiChu"); } set { txt("ghiChu", value); } }

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

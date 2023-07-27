using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowHangMuc = Worksheet.modData.Memories.Record.HangMuc; 
using Worksheet.modData.Memories.Pointer;
using Worksheet.modData.Memories;

namespace Worksheet.modData.Modelv1
{
    internal class HangMuc
    {
        public static void point(int id)
        {
            Current.HM.id(id);
            // reset pointer
            Current.CV = new modData.Memories.Pointer.CongViec();
            Current.NC = new modData.Memories.Pointer.NhanCong();
            Current.VL = new modData.Memories.Pointer.VatLieu();
            Current.CM = new modData.Memories.Pointer.CaMay();
        }
        public static List<RowHangMuc> danhsach()
        {
            List<ARecord> rows = Storage.R.FindAll(Current.HM.filterType);
            return rows.Cast<RowHangMuc>().ToList();
        }
        public static RowHangMuc? chitiet(string index)
        {
            ARecord? row = Storage.R.Find(Current.HM.filterItem);
            return null == row ? null : (RowHangMuc)row;
        }

        public static void them(RowHangMuc r)
        {
            point(r.Id);
            Storage.R.Add(r);
            // recalculate BL
        }
        public static void xoa(string index)
        {
            Storage.R.RemoveAll(Current.HM.filterFamily);
            // recalculate BL
        }
    }
}

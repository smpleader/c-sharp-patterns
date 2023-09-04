using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowHangMuc = modData.Memories.Record.HangMuc;
using modData;
using modData.Memories.Pointer;

namespace modData.Memories.Models
{
    public class HangMuc
    {
        public static void point(int id)
        {
            Current.HM.id(id);
            // reset pointer
            Current.CV = new modData.Memories.Pointer.CongViec();
            Current.NC = new NhanCong();
            Current.VL = new Pointer.VatLieu();
            Current.CM = new CaMay();
        }
        public static List<RowHangMuc> danhsach()
        {
            List<ARecord> rows = memories.Storage.FindAll(Current.HM.filterType);
            return rows.Cast<RowHangMuc>().ToList();
        }
        public static RowHangMuc? chitiet(string index)
        {
            ARecord? row = memories.Storage.Find(Current.HM.filterItem);
            return null == row ? null : (RowHangMuc)row;
        }

        public static void them(RowHangMuc r)
        {
            point(r.Id);
            memories.Storage.Add(r);
            // recalculate BL
        }
        public static void xoa(string index)
        {
            memories.Storage.RemoveAll(Current.HM.filterFamily);
            // recalculate BL
        }
    }
}

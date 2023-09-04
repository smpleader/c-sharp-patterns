using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowCongViec = modData.Memories.Record.CongViec;
using System.Xml;
using modData;
using modData.Memories.Pointer;
using modData.Memories;

namespace modData.Memories.Models
{
    public class CongViec
    {
        public static void point(int id)
        {
            Current.CV.id(id);
            // reset pointer
            Current.NC = new NhanCong();
            Current.VL = new Pointer.VatLieu();
            Current.CM = new CaMay();
        }
        public static List<RowCongViec> danhsach(string index, string? HangMuc = null)
        {
            List<ARecord> rows = memories.Storage.FindAll(Current.CV.filterType);
            return rows.Cast<RowCongViec>().ToList();
        }
        public static List<RowCongViec> danhSachCongViecHangMuc()
        {
            List<ARecord> rows = memories.Storage.FindAll(Current.CV.filterSibling);
            return rows.Cast<RowCongViec>().ToList();
        }
        public static RowCongViec? chitiet(string index = "", string? HangMuc = null)
        {
            ARecord? row = memories.Storage.Find(Current.CV.filterItem);
            return null == row ? null : (RowCongViec)row;
        }

        public static void them(RowCongViec r)
        {
            //int id = Current.CV.id();
            point(r.Id);
            //r.Id = id;
            memories.Storage.Add(r);
            // recalculate BL
        }
        public static void xoa()
        {
            int id = Current.CV.id();
            point(id--);
            memories.Storage.RemoveAll(Current.CV.filterItem);
            // recalculate BL
        }

        public static void capnhat(dynamic row)
        {
            ARecord? find = Current.CV.load(row.Id);
            if (find == null)
            {
                RowCongViec rowCongViec = new RowCongViec(Current.HM.id());
                rowCongViec.ColText = row.ColText;
                rowCongViec.ColNum = row.ColNum;
                rowCongViec.Id = row.Id;

                memories.Storage.Add(rowCongViec);
            }
            else
            {

            }
        }
    }
}

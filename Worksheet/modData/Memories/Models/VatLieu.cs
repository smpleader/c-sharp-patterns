using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowVatLieu = Worksheet.modData.Memories.Record.VatLieu;
using Worksheet.modData.Memories;
using System.Reflection;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Memories.Models
{
    internal class VatLieu
    {
        public static void point(int index)
        {
            Current.VL.id(index);
        }
        public static List<RowVatLieu> danhsach()
        {
            List<ARecord> rows = memories.Storage.FindAll(Current.VL.filterType);
            return rows.Cast<RowVatLieu>().ToList();
        }
        public static RowVatLieu? chitiet()
        {
            ARecord? row = memories.Storage.Find(Current.VL.filterItem);
            return null == row ? null : (RowVatLieu)row;
        }

        public static void them(RowVatLieu r)
        {
            memories.Storage.Add(r);
            // recalculate BL
        }
        public static bool capnhat(RowVatLieu r)
        {
            int index = memories.Storage.FindIndex(x => x.Path == r.Path);
            if (index == -1)

            {
                MessageBox.Show(r.Path + " not found.");
                return false;
            }
            else
            {
                memories.Storage.ElementAt(index).ColText = r.ColText;
                memories.Storage.ElementAt(index).ColNum = r.ColNum;
                // recalculate BL
                return true;
            }
        }
        public static void xoa()
        {
            memories.Storage.RemoveAll(Current.VL.filterItem);
            // recalculate BL
        }

    }
}

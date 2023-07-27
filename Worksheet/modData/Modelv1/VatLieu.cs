using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowVatLieu = Worksheet.modData.Memories.Record.VatLieu;
using Worksheet.modData.Memories;
using System.Reflection;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Modelv1
{
    internal class VatLieu
    {
        public static void point(int index)
        {
            Current.VL.id(index);
        }
        public static List<RowVatLieu> danhsach()
        {
            List<ARecord> rows = Storage.R.FindAll(Current.VL.filterType);
            return rows.Cast<RowVatLieu>().ToList();
        }
        public static RowVatLieu? chitiet()
        {
            ARecord? row = Storage.R.Find(Current.VL.filterItem);
            return null == row ? null : (RowVatLieu)row;
        }

        public static void them(RowVatLieu r)
        {
            Storage.R.Add(r);
            // recalculate BL
        }
        public static bool capnhat(RowVatLieu r)
        {
            int index = Storage.R.FindIndex(x => x.Path == r.Path);
            if (index == -1)
            {
                MessageBox.Show(r.Path + " not found.");
                return false;
            }
            else
            {
                Storage.R.ElementAt(index).ColText = r.ColText;
                Storage.R.ElementAt(index).ColNum = r.ColNum;
                // recalculate BL
                return true;
            }
        }
        public static void xoa()
        {
            Storage.R.RemoveAll(Current.VL.filterItem);
            // recalculate BL
        }

    }
}

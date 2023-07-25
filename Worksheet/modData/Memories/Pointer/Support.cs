using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Pointer
{
    public static class Support
    {
        public static bool isLevel5(this string sth)
        {
            return 5 == sth.Count(s => s == '.');
        }
        public static bool isLevel4(this string sth)
        {
            return 4 == sth.Count(s => s == '.');
        }
        public static bool isLevel3(this string sth)
        {
            return 3 == sth.Count(s => s == '.');
        }
        public static bool isLevel2(this string sth)
        {
            return 2 == sth.Count(s => s == '.');
        }
        public static bool isLevel1(this string sth)
        {
            return 1 == sth.Count(s => s == '.');
        }
    }
}

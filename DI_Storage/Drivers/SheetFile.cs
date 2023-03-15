using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.Drivers
{
    internal class SheetFile
    {
        public static List<string> GetFiles(string path, bool fullPath = false)
        {
            List<string> strs = new List<string>();
            var extList = new List<string> { "*.xlsx", "*.csv", "*.ods", "*.xls" };

            foreach (String ext in extList)
            {
                foreach (String file in Directory.GetFiles(path, ext, SearchOption.AllDirectories))
                {
                    if (fullPath)
                    {
                        strs.Add(file);
                    }
                    else
                    {
                        strs.Add(Path.GetFileName(file).Trim());
                    }
                }
            }

            return strs;
        }
    }
}

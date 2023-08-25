using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modBL;

namespace Worksheet.modDisplay
{
    internal class Resources
    {
        public static string Version { get { return "0.1"; } }
        public static string Release { get { return "20230604"; } }

        public static Dictionary<string, FileTemplate> Files = new Dictionary<string, FileTemplate>() 
        {
            { "", 
                new FileTemplate(){
                    Id = 0,
                    Name = "Default file",
                    Path = "",
                    Version = "0.1",
                    Release = "20230702",
                    Group = new string[] {"Default"},
                    Note = "This is a default value for not found file",
                    Tabs = new Dictionary<string, ISheet>()
                }
            },
            { "Template/TienLuong",
                new FileTemplate(){
                    Id = 2,
                    Name = "Template Tiên lượng",
                    Path = "Content/Template/TienLuong.xlsx",
                    Version = "0.1",
                    Release = "20230702",
                    Group = {},
                    Note = "Dùng cho việc thêm sửa công việc",
                    Tabs = new Dictionary<string, ISheet>()
                    {
                        {"Tiên lượng", new templates.tienluong.Generator()},
                    }
                }
            }
        };
                
    }
}

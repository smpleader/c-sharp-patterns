﻿using System;
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
            { "Dongia",  
                new FileTemplate(){ 
                    Id = 1,
                    Name = "Dongia template",
                    Path = "",
                    Version = "0.1",
                    Release = "20230702",
                    Group = {},
                    Note = "Dùng cho việc nhập liệu đơn giá",
                    Tabs = new Dictionary<string, ISheet>()
                    {
                        {"Công việc", new dongia.congviec.Generator()  },
                        {"Vật liệu", new dongia.vatlieu.Generator()  },
                        {"Tong-hop", new dongia.tonghop.Generator()  },
                    }
                } 
            },
            { "Baogia",
                new FileTemplate(){
                    Id = 2,
                    Name = "Bao gia template",
                    Path = "",
                    Version = "0.1",
                    Release = "20230702",
                    Group = {},
                    Note = "Dùng cho việc nhập liệu báo giá",
                    Tabs = new Dictionary<string, ISheet>()
                    {
                        {"Vật liệu", new dongia.vatlieu.Generator()  },
                        {"Tong-hop", new dongia.tonghop.Generator()  },
                    }
                }
            }
        };


        // TODO: create Files by auto load on the startup
        public static Dictionary<string,  ISheet> tabs = new Dictionary<string, ISheet>()
                {
                    {"default", new AGenerator()  },
                    {"dg/congviec", new dongia.congviec.Generator()  },
                    {"dg/vatlieu", new dongia.vatlieu.Generator()  },
                    {"dg/tonghop", new dongia.tonghop.Generator()  },
                    { "DG", new input_data1.vatlieu.Generator() },
                    { "thvl", new input_data1.vatlieu.Generator()},
                    { "THNC", new input_data1.vatlieu.Generator()}
                };

    }
}

﻿namespace modDisplay
{
    public class Resources
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
            {"Template/TienLuong",
                new FileTemplate(){
                    Id = 1,
                    Name = "Template Tiên lượng",
                    Path = "Content/Template/TienLuong.xlsx",
                    Version = "0.1",
                    Release = "20230702",
                    Group = {},
                    Note = "Dùng cho việc thêm sửa công việc",
                    Tabs = new Dictionary<string, ISheet>()
                    {
                        {"Tiên lượng", new templates.tienluong.Generator()},
                        {"Giá vật liệu", new templates.vatlieu.Generator()},
                    }
                }
            },
            {"Template/cuocoto/theotongculy",
                new FileTemplate(){
                    Id = 2,
                    Name = "Template cho cước ô tô theo tổng cự ly",
                    Path = "Content/Template/cuocoto/theotongculy.xlsx",
                    Version = "0.1",
                    Release = "20230702",
                    Group = {},
                    Note = "Dùng cho việc tính cước ô tô",
                    Tabs = new Dictionary<string, ISheet>()
                    {
                        {"Cước ô tô", new templates.cuocoto.tongculy.Generator()},
                    }
                }
            },
            {"Template/cuocoto/theoloaiphuongtien",
                new FileTemplate(){
                    Id = 2,
                    Name = "Template cho cước ô tô theo loại phương tiện",
                    Path = "Content/Template/cuocoto/theoloaiphuongtien.xlsx",
                    Version = "0.1",
                    Release = "20230702",
                    Group = {},
                    Note = "Dùng cho việc tính cước ô tô",
                    Tabs = new Dictionary<string, ISheet>()
                    {
                        {"Cước ô tô", new templates.cuocoto.loaiphuongtien.Generator()},
                    }
                }
            }
        };

    }
}
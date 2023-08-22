﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }

        public override string Col => "M";
        public override string Name => "VatLieu_CuocOto";
        public override string formula(string[] args)
        {
            switch(Option.PPTCuocOto)
            {
                case PPTCuocOto.TheoTongCuLy:
                    return $"'Cước ô tô'!.Y{args[0]}";
                // todo: thêm các trường hợp cho các ppt khác
            }
            return base.formula(args);
        }
    }
}

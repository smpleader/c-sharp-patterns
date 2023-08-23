﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay
{
    public class ACol
    {
        public ACol(ARowObject r)
        {
            Row = r;
        }
        public ARowObject Row { get; set; }
        public virtual string UniqueName { get { return ""; } }
        public virtual string Col { get { return "A"; } }
        public virtual string TongTienVatTu { get { return ""; } }
        public virtual string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }
        public virtual void render()
        {
            Row.ws[Col + Row.Id] = string.Format(modBL.Container.Get(UniqueName).formula(Params));
        }
    }
}
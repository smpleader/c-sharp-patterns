﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay
{
    internal class APosition : IPosition
    {
        public virtual string Name { get { return "--"; } }
        public unvell.ReoGrid.Worksheet ws;
        public int Id { get; set; }

        public virtual void bind(){}

        public virtual void render(){}
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.MVP_SI.Models
{
    internal class MPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Author { get; set; }

        public string ToString()
        {
            return Title + " " + Content;
        }
    }
}

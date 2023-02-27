using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.MVP_SI.Models;

namespace DI.MVP_SI.Services
{
    internal class SPost
    {
        public MPost GetPost(int Id)
        {
            return new MPost() { Id = Id, Title = "Article 1", Content = "Bla bla bla bal bla" };
        }
    }
}

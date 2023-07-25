using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Worksheet.Data.Entities.User
{
    internal class UserGroup
    {
        public int IdUser { get; set; }
        public int IdGroup { get; set; }
        public override string ToString() { return IdGroup + " " + IdUser; }

    }
}

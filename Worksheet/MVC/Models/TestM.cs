using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Worksheet.modData.Drivers;

namespace Worksheet.MVC.Models
{
    internal class TestM
    {
        public void dosth()
        {
            modData.Sqlite.User tblUser = new modData.Sqlite.User(new  Sqlite("Data Source=database.dat;Version=3;New=True"));
            MessageBox.Show("dosth" + tblUser.Pk().ToString());
        }
    }
}

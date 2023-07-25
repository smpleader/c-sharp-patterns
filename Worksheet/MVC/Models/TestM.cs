using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.DB.SQLite;
using Worksheet.Util.Drivers;

namespace Worksheet.MVC.Models
{
    internal class TestM
    {
        public void dosth()
        {
            User tblUser = new User(new  Sqlite("Data Source=database.dat;Version=3;New=True"));
            MessageBox.Show("dosth" + tblUser.Pk().ToString());
        }
    }
}

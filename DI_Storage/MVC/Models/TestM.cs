using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_Storage.DB.SQLite;

namespace DI_Storage.MVC.Models
{
    internal class TestM
    {
        public void dosth()
        {
            User tblUser = new User(new Drivers.Sqlite("Data Source=database.dat;Version=3;New=True"));
            MessageBox.Show("dosth" + tblUser.Pk().ToString());
        }
    }
}

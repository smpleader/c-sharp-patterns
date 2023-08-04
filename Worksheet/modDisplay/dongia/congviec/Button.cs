using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.dongia.congviec
{
    internal class Button
    {
        private string Name;
        public Button(string name) { Name = name; } 
        public void click()
        {
            MessageBox.Show(Name + " get clicked");
        }
    }
}

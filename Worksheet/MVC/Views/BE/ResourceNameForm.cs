using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worksheet.MVC.Views.BE
{
    public partial class ResourceNameForm : Form
    {
        public ResourceNameForm()
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            btnBack.DialogResult = DialogResult.Cancel;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string safename = new String(txtName.Text.Where(c => c == '_' || (Char.IsLetterOrDigit(c))).ToArray()) ;
            filename.Text = String.IsNullOrEmpty(safename) ? "" : safename + ".xlsx";
        }
    }
}

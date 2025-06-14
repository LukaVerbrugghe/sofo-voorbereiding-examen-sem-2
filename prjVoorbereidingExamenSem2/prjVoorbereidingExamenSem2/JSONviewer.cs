using prjVoorbereidingExamenSem2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVoorbereidingExamenSem2
{
    public partial class JSONviewer : Form
    {
        public JSONviewer()
        {
            InitializeComponent();
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            Schoolklasse school = new Schoolklasse();
            foreach (Schoolklasse s in school.Listscholen) { 
                lsbJSONData.Items.Add(s);
            }
        }
    }
}

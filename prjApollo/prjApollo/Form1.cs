using prjApollo.DA;
using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjApollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            laadLeveranciers();
        }

        private void laadLeveranciers()
        {
            lsvLeveranciers.Items.Clear();
            foreach(Leverancier l in LeveranciersDA.OphalenLeveranciers())
            {
                ListViewItem item = new ListViewItem(new string[] {l.leveranciernummer.ToString(), l.firmanaam, l.adres, l.postnr, l.gemeente});
                item.Tag = l;
                lsvLeveranciers.Items.Add(item);
            }
        }
    }
}

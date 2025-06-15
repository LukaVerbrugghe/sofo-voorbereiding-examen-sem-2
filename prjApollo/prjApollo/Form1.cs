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

        private void lsvLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvLeveranciers.SelectedItems.Count == 0)
                return;

            ListViewItem item = lsvLeveranciers.SelectedItems[0];

            txtLevernummer.Text = item.Text;
            txtFirmanaam.Text = item.SubItems[1].Text;
            txtAdres.Text = item.SubItems[2].Text;
            txtPostnr.Text = item.SubItems[3].Text;
            txtGemeente.Text = item.SubItems[4].Text;

            //inladen wijnen
            lsvWijnen.Items.Clear();
            foreach(Wijn w in WijnenDA.OphalenWijenen(Convert.ToInt32(item.Text))){
                ListViewItem wijnItem = new ListViewItem(new string[] {w.Code, w.Jaar, w.Omschrijving, w.Inhoud, w.PrijsPerFles.ToString(), w.HoeveelheidPerVerpakking.ToString(), w.Voorraad.ToString()});
                wijnItem.Tag = w;
                lsvWijnen.Items.Add(wijnItem);
            }
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            Leverancier leverancier = new Leverancier();

            leverancier.leveranciernummer = Convert.ToInt32(txtLevernummer.Text);
            leverancier.firmanaam = txtFirmanaam.Text;
            leverancier.adres = txtAdres.Text;
            leverancier.postnr = txtPostnr.Text;
            leverancier.gemeente = txtGemeente.Text;

            LeveranciersDA.Edit(leverancier);

            laadLeveranciers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Leverancier leverancier = new Leverancier();

            leverancier.firmanaam = txtFirmanaam.Text;
            leverancier.adres = txtAdres.Text;
            leverancier.postnr = txtPostnr.Text;
            leverancier.gemeente = txtGemeente.Text;

            LeveranciersDA.Add(leverancier);

            laadLeveranciers();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            LeveranciersDA.Delete(Convert.ToInt32(txtLevernummer.Text));
            laadLeveranciers();
        }

        private void btnWijzigWijn_Click(object sender, EventArgs e)
        {
            Wijn wijn = new Wijn();

            wijn.Code = txtCode.Text;
            wijn.Jaar = txtJaar.Text;
            wijn.Omschrijving = txtOmschrijving.Text;
            wijn.Inhoud = txtInhoud.Text;
            wijn.PrijsPerFles = Convert.ToDouble(txtPpf.Text);
            wijn.HoeveelheidPerVerpakking = Convert.ToInt32(txtPpp.Text);
            wijn.Voorraad = Convert.ToInt32(txtVoorraad.Text);
        }

        private void lsvWijnen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvWijnen.SelectedItems.Count == 0)
                return;

            ListViewItem item = lsvWijnen.SelectedItems[0];

            txtCode.Text = item.Text;
            txtJaar.Text = item.SubItems[1].Text;
            txtOmschrijving.Text = item.SubItems[2].Text;
            txtInhoud.Text = item.SubItems[3].Text;
            txtPpf.Text = item.SubItems[4].Text;
            txtPpp.Text = item.SubItems[5].Text;
            txtVoorraad.Text = item.SubItems[6].Text;

            
        }
    }
}

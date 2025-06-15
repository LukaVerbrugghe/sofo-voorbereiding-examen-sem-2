namespace prjApollo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvLeveranciers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLevernummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmanaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lsvWijnen = new System.Windows.Forms.ListView();
            this.cboSorteerWijnen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtJaar = new System.Windows.Forms.TextBox();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.txtPpf = new System.Windows.Forms.TextBox();
            this.txtPpp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVoorraad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInhoud = new System.Windows.Forms.TextBox();
            this.btnWijzigWijn = new System.Windows.Forms.Button();
            this.btnAddWijn = new System.Windows.Forms.Button();
            this.btnVerwijderWijn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvLeveranciers
            // 
            this.lsvLeveranciers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvLeveranciers.FullRowSelect = true;
            this.lsvLeveranciers.HideSelection = false;
            this.lsvLeveranciers.Location = new System.Drawing.Point(13, 13);
            this.lsvLeveranciers.Name = "lsvLeveranciers";
            this.lsvLeveranciers.Size = new System.Drawing.Size(496, 289);
            this.lsvLeveranciers.TabIndex = 0;
            this.lsvLeveranciers.UseCompatibleStateImageBehavior = false;
            this.lsvLeveranciers.View = System.Windows.Forms.View.Details;
            this.lsvLeveranciers.SelectedIndexChanged += new System.EventHandler(this.lsvLeveranciers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Levnr";
            // 
            // txtLevernummer
            // 
            this.txtLevernummer.Location = new System.Drawing.Point(16, 343);
            this.txtLevernummer.Name = "txtLevernummer";
            this.txtLevernummer.Size = new System.Drawing.Size(100, 20);
            this.txtLevernummer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firmanaam";
            // 
            // txtFirmanaam
            // 
            this.txtFirmanaam.Location = new System.Drawing.Point(159, 343);
            this.txtFirmanaam.Name = "txtFirmanaam";
            this.txtFirmanaam.Size = new System.Drawing.Size(100, 20);
            this.txtFirmanaam.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(300, 343);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Postnr";
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(16, 402);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtPostnr.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gemeente";
            // 
            // txtGemeente
            // 
            this.txtGemeente.Location = new System.Drawing.Point(159, 402);
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.Size = new System.Drawing.Size(100, 20);
            this.txtGemeente.TabIndex = 2;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(16, 454);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnWijzig.TabIndex = 3;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(300, 454);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // lsvWijnen
            // 
            this.lsvWijnen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lsvWijnen.FullRowSelect = true;
            this.lsvWijnen.HideSelection = false;
            this.lsvWijnen.Location = new System.Drawing.Point(593, 57);
            this.lsvWijnen.Name = "lsvWijnen";
            this.lsvWijnen.Size = new System.Drawing.Size(485, 245);
            this.lsvWijnen.TabIndex = 4;
            this.lsvWijnen.UseCompatibleStateImageBehavior = false;
            this.lsvWijnen.View = System.Windows.Forms.View.Details;
            // 
            // cboSorteerWijnen
            // 
            this.cboSorteerWijnen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSorteerWijnen.FormattingEnabled = true;
            this.cboSorteerWijnen.Items.AddRange(new object[] {
            "Code",
            "Jaar",
            "Omschrijving",
            "Inhoud",
            "ppf",
            "Prijs per pak (hoeveelheid)",
            "Voorraad"});
            this.cboSorteerWijnen.Location = new System.Drawing.Point(763, 29);
            this.cboSorteerWijnen.Name = "cboSorteerWijnen";
            this.cboSorteerWijnen.Size = new System.Drawing.Size(121, 21);
            this.cboSorteerWijnen.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Jaar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(975, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Omschrijving";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ppf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(834, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Prijs per pak";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(694, 343);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtJaar
            // 
            this.txtJaar.Location = new System.Drawing.Point(837, 343);
            this.txtJaar.Name = "txtJaar";
            this.txtJaar.Size = new System.Drawing.Size(100, 20);
            this.txtJaar.TabIndex = 2;
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(978, 343);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(100, 20);
            this.txtOmschrijving.TabIndex = 2;
            // 
            // txtPpf
            // 
            this.txtPpf.Location = new System.Drawing.Point(694, 402);
            this.txtPpf.Name = "txtPpf";
            this.txtPpf.Size = new System.Drawing.Size(100, 20);
            this.txtPpf.TabIndex = 2;
            // 
            // txtPpp
            // 
            this.txtPpp.Location = new System.Drawing.Point(837, 402);
            this.txtPpp.Name = "txtPpp";
            this.txtPpp.Size = new System.Drawing.Size(100, 20);
            this.txtPpp.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(975, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Voorraad";
            // 
            // txtVoorraad
            // 
            this.txtVoorraad.Location = new System.Drawing.Point(978, 402);
            this.txtVoorraad.Name = "txtVoorraad";
            this.txtVoorraad.Size = new System.Drawing.Size(100, 20);
            this.txtVoorraad.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(569, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Inhoud";
            // 
            // txtInhoud
            // 
            this.txtInhoud.Location = new System.Drawing.Point(572, 402);
            this.txtInhoud.Name = "txtInhoud";
            this.txtInhoud.Size = new System.Drawing.Size(100, 20);
            this.txtInhoud.TabIndex = 2;
            // 
            // btnWijzigWijn
            // 
            this.btnWijzigWijn.Location = new System.Drawing.Point(694, 454);
            this.btnWijzigWijn.Name = "btnWijzigWijn";
            this.btnWijzigWijn.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigWijn.TabIndex = 3;
            this.btnWijzigWijn.Text = "Wijzig";
            this.btnWijzigWijn.UseVisualStyleBackColor = true;
            // 
            // btnAddWijn
            // 
            this.btnAddWijn.Location = new System.Drawing.Point(837, 454);
            this.btnAddWijn.Name = "btnAddWijn";
            this.btnAddWijn.Size = new System.Drawing.Size(75, 23);
            this.btnAddWijn.TabIndex = 3;
            this.btnAddWijn.Text = "Add";
            this.btnAddWijn.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderWijn
            // 
            this.btnVerwijderWijn.Location = new System.Drawing.Point(978, 454);
            this.btnVerwijderWijn.Name = "btnVerwijderWijn";
            this.btnVerwijderWijn.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderWijn.TabIndex = 3;
            this.btnVerwijderWijn.Text = "Verwijder";
            this.btnVerwijderWijn.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lvnr";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firma naam";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PostNr";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gemeente";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Code";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Jaar";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Omschrijving";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Inhoud";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ppf";
            this.columnHeader10.Width = 40;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Hoeveelheid";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Voorraad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 491);
            this.Controls.Add(this.cboSorteerWijnen);
            this.Controls.Add(this.lsvWijnen);
            this.Controls.Add(this.btnVerwijderWijn);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnAddWijn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnWijzigWijn);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.txtVoorraad);
            this.Controls.Add(this.txtPpp);
            this.Controls.Add(this.txtGemeente);
            this.Controls.Add(this.txtInhoud);
            this.Controls.Add(this.txtPpf);
            this.Controls.Add(this.txtPostnr);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtJaar);
            this.Controls.Add(this.txtFirmanaam);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtLevernummer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvLeveranciers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvLeveranciers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLevernummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmanaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListView lsvWijnen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cboSorteerWijnen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtJaar;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.TextBox txtPpf;
        private System.Windows.Forms.TextBox txtPpp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVoorraad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInhoud;
        private System.Windows.Forms.Button btnWijzigWijn;
        private System.Windows.Forms.Button btnAddWijn;
        private System.Windows.Forms.Button btnVerwijderWijn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}


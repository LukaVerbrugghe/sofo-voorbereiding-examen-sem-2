using Microsoft.SqlServer.Server;
using prjVoorbereidingExamenSem2.DA;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = txtLoginGebruikersnaam.Text;
            user.Password = txtLoginWachtwoord.Text;

            if (userDA.LoginValidate(user))
            {
                JSONviewer jSONviewer = new JSONviewer();
                jSONviewer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dit is niet juist");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtSignupWachtwoord.Text == txtSignupBevestigWachtwoord.Text) {
                User user = new User();
                user.Username = txtSignupGebruikersnaam.Text;
                user.Password = txtSignupWachtwoord.Text;

                userDA.Register(user);
            }
            else
            {
                MessageBox.Show("Wachtwoorden verschillend");
            }
        }
    }
}

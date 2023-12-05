using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace P_Secu_Gestionnaire_mdp
{
    public partial class Ajout_de_données : Form
    {
        
        public Ajout_de_données()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtboxMdp.PasswordChar = '*';
            txtboxMdpConf.PasswordChar = '*';
            this.MaximizeBox = false;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            string cheminRelatif = "../../../DATA/" + txtboxSite.Text + "/"; // Chemin relatif du fichier
            string cheminComplet = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminRelatif);

            string verifPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../DATA/" + txtboxSite.Text);



            if (txtboxMdp.Text != txtboxMdpConf.Text)
            {
                MessageBox.Show("Le mot de passe et sa confirmation ne concordent pas.", "Vérifiez votre mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxMdpConf.Text = "";
                txtboxMdp.Text = "";
            }
            else if (txtboxSite.Text.Contains('/') || txtboxSite.Text.Contains('|') || txtboxSite.Text.Contains(':') || txtboxSite.Text.Contains('*') || txtboxSite.Text.Contains('?') || txtboxSite.Text.Contains('<') || txtboxSite.Text.Contains('>'))
            {
                MessageBox.Show("Veuillez entrez seulement le titre du site web, ces caractères ne sont pas accepter : / | : * ? < > ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxSite.Text = "";
            }
            else if (Directory.Exists(verifPath))
            {
                MessageBox.Show("Vous avez déjà enregistré vos informations concernant ce site web.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxSite.Text = "";
            }
            else if (string.IsNullOrEmpty(txtboxExt.Text)||string.IsNullOrEmpty(txtboxId.Text)||string.IsNullOrEmpty(txtboxMdp.Text)||string.IsNullOrEmpty(txtboxSite.Text)||string.IsNullOrEmpty(txtboxMdpConf.Text))
            {
                MessageBox.Show("Veuillez remplir tous les espaces svp ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {

                
                string mdp = txtboxMdp.Text;

                char[] mdpInverse = mdp.ToCharArray();
                Array.Reverse(mdpInverse);

                char[] charsEncode = new char[mdpInverse.Length];

                for (int i = 0; i < mdpInverse.Length; i++)
                {
                    char c = mdpInverse[i];
                    int valeurEncode = (int)c*2-10;
                    charsEncode[i] = (char)valeurEncode;
                }

                Directory.CreateDirectory(cheminComplet);
                Directory.CreateDirectory(Path.Combine(cheminComplet, "Identifiant"));
                Directory.CreateDirectory(Path.Combine(cheminComplet, "Mot De Passe"));
                Directory.CreateDirectory(Path.Combine(cheminComplet, "Extension"));


                Directory.CreateDirectory(cheminComplet + "Identifiant");
                using (StreamWriter sw = File.AppendText(Path.Combine(cheminComplet, "Identifiant", "identifiant_" + txtboxSite.Text + ".txt")))
                {
                    sw.WriteLine(txtboxId.Text);
                }

                Directory.CreateDirectory(cheminComplet + "Mot De Passe");
                using (StreamWriter sw = File.AppendText(Path.Combine(cheminComplet, "Mot De Passe", "motdepasse_" + txtboxSite.Text + ".txt")))
                {
                    sw.WriteLine(new string(charsEncode));
                }

                Directory.CreateDirectory(cheminComplet + "Extension");
                using (StreamWriter sw = File.AppendText(Path.Combine(cheminComplet, "Extension", "extension_" + txtboxSite.Text + ".txt")))
                {
                    sw.WriteLine(txtboxExt.Text);
                }
           
                Accueil nf = new Accueil();
                nf.Show();
                this.Hide();
                
            }

            
            
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Accueil nf = new Accueil();
            nf.Show();
            this.Hide();
        }





        private void txtboxExt_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtboxExt_Click(object sender, EventArgs e)
        {
            
        }

        

        
        
    }
}

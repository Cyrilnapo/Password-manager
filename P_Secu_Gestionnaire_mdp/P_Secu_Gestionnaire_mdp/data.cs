using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Secu_Gestionnaire_mdp
{
    public partial class data : Form
    {
        public static data instance;
        public Label titre;
        public Label motDePasse;
        public Label username;


        public data()
        {
            InitializeComponent();
            instance = this;
            titre = lblTitre;
            motDePasse = lblMdp;
            username = lblUser;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            
            this.MaximizeBox = false;
            lblMdp.Hide();
        }
        private void show(object sender, MouseEventArgs e)
        {
            lblMdp.Show();
        }

        private void unshow(object sender, MouseEventArgs e)
        {
            lblMdp.Hide();

        }




        private void btnSeeMdp_Click(object sender, EventArgs e)
        {

        }

        

        private void data_Load(object sender, EventArgs e)
        {

        }

        private void lblMdp_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using System.CodeDom;

namespace P_Secu_Gestionnaire_mdp
{
    public partial class Accueil : Form
    {
        public static Accueil instance;
       
        public Accueil()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            instance = this;



            string cheminRelatif = "../../../DATA"; // Chemin relatif du fichier
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminRelatif);

            string[] listDossiers = Directory.GetDirectories(filePath).ToArray();


            for (int i = 0; i < listDossiers.Length ; i++)
            {
                bool isHidden = ((File.GetAttributes(listDossiers[i]) & FileAttributes.Hidden) == FileAttributes.Hidden);

                if (!isHidden)
                {
                    
                    var startOfName = listDossiers[i].LastIndexOf("\\");
                    var fileName = listDossiers[i].Substring(startOfName + 1, listDossiers[i].Length - (startOfName + 1));

                    
                    Button dataButton = new Button();
                    dataButton.Text = fileName;
                    dataButton.Name = listDossiers[i];
                    dataButton.Location = new Point(70, 70);
                    dataButton.Size = new Size(99, 34);
                    dataButton.TextAlign = ContentAlignment.MiddleCenter;
                    dataButton.Padding = new Padding(0, 0, 0, 0);
                    pnlDossiers.Controls.Add(dataButton);
                    dataButton.BackColor = SystemColors.Control;

                    
                    dataButton.Click += Button_Click;
                    
                }
            }
           
        }
        private void Button_Click(object sender, EventArgs e)
        {
            data dta = new data();
            dta.Show();

            string cheminRelatif = "../../../DATA/"; // Chemin relatif du fichier
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminRelatif);



            Button btn = sender as Button;
            
            string mdp = File.ReadAllText(filePath + "\\"+ btn.Text + "\\Mot De Passe\\" + "motdepasse_"+btn.Text+".txt");
            string username = File.ReadAllText(filePath + "\\" + btn.Text + "\\Identifiant\\" + "identifiant_" + btn.Text + ".txt");
            string extension = File.ReadAllText(filePath + "\\" + btn.Text + "\\Extension\\" + "extension_" + btn.Text + ".txt");


            char[] mdpInverse = mdp.ToCharArray();
            Array.Reverse(mdpInverse);




            char[] charsEncode = new char[mdpInverse.Length];

            for (int i = 0; i < mdpInverse.Length; i++)
            {
                char c = mdpInverse[i];
                int valeurEncode = ((int)c + 10)/ 2;
                charsEncode[i] = (char)valeurEncode;
            }
            string intermediaire = new string(charsEncode);

            string final = intermediaire.Remove(0,2);

            data.instance.titre.Text = "Vos identifiants "+ btn.Text +"."+ extension;
            data.instance.motDePasse.Text = final;
            data.instance.username.Text = username;
           

            
        }
       

        private void btnSuppData_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuppData spd = new SuppData();
            spd.Show();
        }
        private void btnModifData_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifData mdt = new ModifData();
            mdt.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_de_données nd = new Ajout_de_données();
            nd.ShowDialog();
        }
        
        

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        
    }
}

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
    public partial class ModifData : Form
    {
        public static ModifData instance;
        public ModifData()
        {
            InitializeComponent();
            instance = this;

            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            string cheminRelatif = "../../../DATA"; // Chemin relatif du fichier
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminRelatif);

            string[] listDossiers = Directory.GetDirectories(filePath).ToArray();


            for (int i = 0; i < listDossiers.Length; i++)
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
            this.Hide();
            Editing edt = new Editing();
            edt.Show();

            Button btn = sender as Button;
            string cheminRelatif = "../../../DATA"; // Chemin relatif du fichier
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminRelatif);
            string directory = filePath + "\\" + btn.Text;

            
            string username = File.ReadAllText(filePath + "\\" + btn.Text + "\\Identifiant\\" + "identifiant_" + btn.Text + ".txt");
            string extension = File.ReadAllText(filePath + "\\" + btn.Text + "\\Extension\\" + "extension_" + btn.Text + ".txt");
            string site = btn.Text;

            Editing.instance.site.Text = site;
            Editing.instance.username.Text = username;
            Editing.instance.extension.Text = extension;
            Editing.instance.deleteSite = site;
            


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Accueil acc = new Accueil();
            acc.Show();
            this.Hide();
        }
    }
}

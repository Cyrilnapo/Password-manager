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

namespace P_Secu_Gestionnaire_mdp
{
    public partial class SuppData : Form
    {
        public SuppData()
        {
            InitializeComponent();

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
            Button btn = sender as Button;
            string cheminRelatif = "../../../DATA"; // Chemin relatif du fichier
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminRelatif);
            string directory = filePath + "\\" + btn.Text;

            Directory.Delete(directory, true);


            this.Hide();
            Accueil acc = new Accueil();
            acc.Show();


        }
        private void SuppData_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Accueil acc = new Accueil();
            acc.Show();
            this.Hide();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Accueil acc = new Accueil();
            acc.Show();
            this.Hide();
        }
    }
}

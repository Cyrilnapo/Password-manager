namespace P_Secu_Gestionnaire_mdp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtboxPassword.MaxLength = 17;
            txtboxPassword.KeyDown += new KeyEventHandler(txtboxPassword_KeyDown);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        const string MasterPassword = "bienvenue2023";
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == MasterPassword)
            {
                MessageBox.Show("Mot de passe correct", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Accueil acc = new Accueil();
                acc.ShowDialog();
            }
            else
            {
                DialogResult d = MessageBox.Show("Non valide", "Le mot de passe que vous avez entrez n'est pas correct",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (d == DialogResult.Cancel)
                {
                    this.Close();
                }
                else if (d == DialogResult.Retry)
                {
                    txtboxPassword.Text = "";
                }
            }
        }
        private void txtboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
            }
        }
        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
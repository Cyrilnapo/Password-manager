namespace P_Secu_Gestionnaire_mdp
{
    partial class data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data));
            label1 = new Label();
            lblTitre = new Label();
            lblMdp = new Label();
            lblUser = new Label();
            btnSeeMdp = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 152);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblTitre
            // 
            lblTitre.BackColor = Color.Transparent;
            lblTitre.Dock = DockStyle.Top;
            lblTitre.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.ForeColor = Color.White;
            lblTitre.Location = new Point(0, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(316, 67);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Vos identifiants exemple.com";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMdp.ForeColor = Color.White;
            lblMdp.Location = new Point(153, 105);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(42, 21);
            lblMdp.TabIndex = 1;
            lblMdp.Text = "mdp";
            lblMdp.Click += lblMdp_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(187, 61);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(23, 21);
            lblUser.TabIndex = 2;
            lblUser.Text = "id";
            // 
            // btnSeeMdp
            // 
            btnSeeMdp.Location = new Point(97, 147);
            btnSeeMdp.Name = "btnSeeMdp";
            btnSeeMdp.Size = new Size(121, 34);
            btnSeeMdp.TabIndex = 4;
            btnSeeMdp.Text = "Voir mot de passe";
            btnSeeMdp.UseVisualStyleBackColor = true;
            btnSeeMdp.Click += btnSeeMdp_Click;
            btnSeeMdp.MouseDown += show;
            btnSeeMdp.MouseUp += unshow;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 105);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 5;
            label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 61);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 6;
            label3.Text = "Nom d'utilisateur :";
            // 
            // data
            // 
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(316, 207);
            Controls.Add(lblTitre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSeeMdp);
            Controls.Add(lblUser);
            Controls.Add(lblMdp);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "data";
            Load += data_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitre;
        private Label lblMdp;
        private Label lblUser;
        private Button btnSeeMdp;
        private Label label2;
        private Label label3;
    }
}
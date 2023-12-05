namespace P_Secu_Gestionnaire_mdp
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDossiers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSuppData = new System.Windows.Forms.Button();
            this.btnModifData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nouvelles données";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDossiers
            // 
            this.pnlDossiers.Location = new System.Drawing.Point(40, 106);
            this.pnlDossiers.Name = "pnlDossiers";
            this.pnlDossiers.Size = new System.Drawing.Size(110, 406);
            this.pnlDossiers.TabIndex = 1;
            // 
            // btnSuppData
            // 
            this.btnSuppData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppData.Location = new System.Drawing.Point(21, 46);
            this.btnSuppData.Name = "btnSuppData";
            this.btnSuppData.Size = new System.Drawing.Size(140, 23);
            this.btnSuppData.TabIndex = 2;
            this.btnSuppData.Text = "Supprimer des données";
            this.btnSuppData.UseVisualStyleBackColor = true;
            this.btnSuppData.Click += new System.EventHandler(this.btnSuppData_Click);
            // 
            // btnModifData
            // 
            this.btnModifData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifData.Location = new System.Drawing.Point(21, 70);
            this.btnModifData.Name = "btnModifData";
            this.btnModifData.Size = new System.Drawing.Size(140, 23);
            this.btnModifData.TabIndex = 3;
            this.btnModifData.Text = "Modifier des données";
            this.btnModifData.UseVisualStyleBackColor = true;
            this.btnModifData.Click += new System.EventHandler(this.btnModifData_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(184, 524);
            this.Controls.Add(this.btnModifData);
            this.Controls.Add(this.btnSuppData);
            this.Controls.Add(this.pnlDossiers);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private FlowLayoutPanel pnlDossiers;
        private Button btnSuppData;
        private Button btnModifData;
    }
}
using System.Windows.Forms;

namespace location_voiture
{
    partial class FormVoiture
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.txtCarburant = new System.Windows.Forms.TextBox();
            this.txtNbPlaces = new System.Windows.Forms.TextBox();
            this.txtKilometrage = new System.Windows.Forms.TextBox();
            this.txtPrixParJour = new System.Windows.Forms.TextBox();
            this.txtEtat = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblCarburant = new System.Windows.Forms.Label();
            this.lblNbPlaces = new System.Windows.Forms.Label();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.lblPrixParJour = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(340, 57);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(150, 22);
            this.txtMatricule.TabIndex = 9;
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(71, 60);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(150, 22);
            this.txtMarque.TabIndex = 10;
            this.txtMarque.TextChanged += new System.EventHandler(this.txtMarque_TextChanged);
            // 
            // txtModele
            // 
            this.txtModele.Location = new System.Drawing.Point(71, 104);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(150, 22);
            this.txtModele.TabIndex = 11;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(71, 140);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(150, 22);
            this.txtCouleur.TabIndex = 12;
            // 
            // txtCarburant
            // 
            this.txtCarburant.Location = new System.Drawing.Point(71, 180);
            this.txtCarburant.Name = "txtCarburant";
            this.txtCarburant.Size = new System.Drawing.Size(150, 22);
            this.txtCarburant.TabIndex = 13;
            // 
            // txtNbPlaces
            // 
            this.txtNbPlaces.Location = new System.Drawing.Point(71, 220);
            this.txtNbPlaces.Name = "txtNbPlaces";
            this.txtNbPlaces.Size = new System.Drawing.Size(150, 22);
            this.txtNbPlaces.TabIndex = 14;
            // 
            // txtKilometrage
            // 
            this.txtKilometrage.Location = new System.Drawing.Point(340, 107);
            this.txtKilometrage.Name = "txtKilometrage";
            this.txtKilometrage.Size = new System.Drawing.Size(150, 22);
            this.txtKilometrage.TabIndex = 15;
            // 
            // txtPrixParJour
            // 
            this.txtPrixParJour.Location = new System.Drawing.Point(340, 144);
            this.txtPrixParJour.Name = "txtPrixParJour";
            this.txtPrixParJour.Size = new System.Drawing.Size(150, 22);
            this.txtPrixParJour.TabIndex = 16;
            // 
            // txtEtat
            // 
            this.txtEtat.Location = new System.Drawing.Point(340, 184);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.Size = new System.Drawing.Size(150, 22);
            this.txtEtat.TabIndex = 17;
            // 
            // lblMatricule
            // 
            this.lblMatricule.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMatricule.Location = new System.Drawing.Point(227, 59);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(100, 23);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblMarque
            // 
            this.lblMarque.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarque.Location = new System.Drawing.Point(2, 59);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(68, 23);
            this.lblMarque.TabIndex = 1;
            this.lblMarque.Text = "Marque";
            // 
            // lblModele
            // 
            this.lblModele.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModele.Location = new System.Drawing.Point(2, 103);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(68, 23);
            this.lblModele.TabIndex = 2;
            this.lblModele.Text = "Modele";
            // 
            // lblCouleur
            // 
            this.lblCouleur.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCouleur.Location = new System.Drawing.Point(2, 139);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(68, 23);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "Couleur";
            // 
            // lblCarburant
            // 
            this.lblCarburant.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarburant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarburant.Location = new System.Drawing.Point(2, 180);
            this.lblCarburant.Name = "lblCarburant";
            this.lblCarburant.Size = new System.Drawing.Size(68, 23);
            this.lblCarburant.TabIndex = 4;
            this.lblCarburant.Text = "Carburant";
            this.lblCarburant.Click += new System.EventHandler(this.lblCarburant_Click);
            // 
            // lblNbPlaces
            // 
            this.lblNbPlaces.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPlaces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNbPlaces.Location = new System.Drawing.Point(2, 219);
            this.lblNbPlaces.Name = "lblNbPlaces";
            this.lblNbPlaces.Size = new System.Drawing.Size(68, 23);
            this.lblNbPlaces.TabIndex = 5;
            this.lblNbPlaces.Text = "NbPlaces";
            // 
            // lblKilometrage
            // 
            this.lblKilometrage.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometrage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKilometrage.Location = new System.Drawing.Point(227, 107);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(100, 23);
            this.lblKilometrage.TabIndex = 6;
            this.lblKilometrage.Text = "Kilometrage";
            // 
            // lblPrixParJour
            // 
            this.lblPrixParJour.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixParJour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrixParJour.Location = new System.Drawing.Point(227, 143);
            this.lblPrixParJour.Name = "lblPrixParJour";
            this.lblPrixParJour.Size = new System.Drawing.Size(100, 23);
            this.lblPrixParJour.TabIndex = 7;
            this.lblPrixParJour.Text = "PrixParJour";
            // 
            // lblEtat
            // 
            this.lblEtat.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEtat.Location = new System.Drawing.Point(227, 183);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(100, 23);
            this.lblEtat.TabIndex = 8;
            this.lblEtat.Text = "Etat";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::location_voiture.Properties.Resources.ajouter;
            this.btnAjouter.Location = new System.Drawing.Point(656, 34);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(132, 128);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = global::location_voiture.Properties.Resources.images;
            this.btnModifier.Location = new System.Drawing.Point(496, 34);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(132, 128);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::location_voiture.Properties.Resources.supprimer;
            this.btnSupprimer.Location = new System.Drawing.Point(656, 180);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(132, 128);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Image = global::location_voiture.Properties.Resources.rechercher;
            this.btnRechercher.Location = new System.Drawing.Point(496, 180);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(132, 128);
            this.btnRechercher.TabIndex = 21;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(20, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 250);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 40);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Gestion des Voitures";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // FormVoiture
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblCarburant);
            this.Controls.Add(this.lblNbPlaces);
            this.Controls.Add(this.lblKilometrage);
            this.Controls.Add(this.lblPrixParJour);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.txtCarburant);
            this.Controls.Add(this.txtNbPlaces);
            this.Controls.Add(this.txtKilometrage);
            this.Controls.Add(this.txtPrixParJour);
            this.Controls.Add(this.txtEtat);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVoiture";
            this.Text = "Gestion des Voitures";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox txtCarburant;
        private System.Windows.Forms.TextBox txtNbPlaces;
        private System.Windows.Forms.TextBox txtKilometrage;
        private System.Windows.Forms.TextBox txtPrixParJour;
        private System.Windows.Forms.TextBox txtEtat;

        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblCarburant;
        private System.Windows.Forms.Label lblNbPlaces;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.Label lblPrixParJour;
        private System.Windows.Forms.Label lblEtat;

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRechercher;

        private System.Windows.Forms.DataGridView dataGridView1;
        private Label lblTitle;
    }
}

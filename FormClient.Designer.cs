namespace location_voiture
{
    partial class FormClient
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCin;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPren;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgvClient;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCin = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPren = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAdr = new System.Windows.Forms.Label();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPren = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(26, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestion des Clients";
            // 
            // lblCin
            // 
            this.lblCin.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCin.Location = new System.Drawing.Point(34, 73);
            this.lblCin.Name = "lblCin";
            this.lblCin.Size = new System.Drawing.Size(100, 23);
            this.lblCin.TabIndex = 1;
            this.lblCin.Text = "CIN";
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNom.Location = new System.Drawing.Point(34, 113);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 23);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblPren
            // 
            this.lblPren.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPren.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPren.Location = new System.Drawing.Point(34, 149);
            this.lblPren.Name = "lblPren";
            this.lblPren.Size = new System.Drawing.Size(100, 23);
            this.lblPren.TabIndex = 3;
            this.lblPren.Text = "Prénom";
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTel.Location = new System.Drawing.Point(34, 190);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 23);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Téléphone";
            // 
            // lblAdr
            // 
            this.lblAdr.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdr.Location = new System.Drawing.Point(34, 230);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(100, 23);
            this.lblAdr.TabIndex = 5;
            this.lblAdr.Text = "Adresse";
            // 
            // txtCin
            // 
            this.txtCin.Location = new System.Drawing.Point(140, 70);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(200, 22);
            this.txtCin.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(140, 110);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 22);
            this.txtNom.TabIndex = 7;
            // 
            // txtPren
            // 
            this.txtPren.Location = new System.Drawing.Point(140, 150);
            this.txtPren.Name = "txtPren";
            this.txtPren.Size = new System.Drawing.Size(200, 22);
            this.txtPren.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(140, 190);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 22);
            this.txtTel.TabIndex = 9;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(140, 230);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(200, 60);
            this.txtAdresse.TabIndex = 10;
            // 
            // dgvClient
            // 
            this.dgvClient.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvClient.ColumnHeadersHeight = 29;
            this.dgvClient.Location = new System.Drawing.Point(56, 340);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.Size = new System.Drawing.Size(550, 200);
            this.dgvClient.TabIndex = 15;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::location_voiture.Properties.Resources.ajouter;
            this.btnAjouter.Location = new System.Drawing.Point(480, 42);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(126, 127);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = global::location_voiture.Properties.Resources.images;
            this.btnModifier.Location = new System.Drawing.Point(348, 175);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(126, 122);
            this.btnModifier.TabIndex = 12;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::location_voiture.Properties.Resources.supprimer;
            this.btnSupprimer.Location = new System.Drawing.Point(480, 175);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(126, 122);
            this.btnSupprimer.TabIndex = 13;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Image = global::location_voiture.Properties.Resources.rechercher;
            this.btnRechercher.Location = new System.Drawing.Point(348, 46);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(126, 127);
            this.btnRechercher.TabIndex = 14;
            // 
            // FormClient
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCin);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPren);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblAdr);
            this.Controls.Add(this.txtCin);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPren);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dgvClient);
            this.Name = "FormClient";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

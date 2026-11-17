namespace location_voiture
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnVoiture = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // btnClient
            // 
            this.btnClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClient.Image = global::location_voiture.Properties.Resources.cl;
            this.btnClient.Location = new System.Drawing.Point(497, 109);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(202, 204);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Clients";
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnVoiture
            // 
            this.btnVoiture.Image = global::location_voiture.Properties.Resources.v;
            this.btnVoiture.Location = new System.Drawing.Point(271, 109);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(202, 204);
            this.btnVoiture.TabIndex = 2;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Image = global::location_voiture.Properties.Resources.download;
            this.btnLocation.Location = new System.Drawing.Point(25, 109);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(202, 204);
            this.btnLocation.TabIndex = 3;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnVoiture);
            this.Controls.Add(this.btnLocation);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnVoiture;
        private System.Windows.Forms.Button btnLocation;
        protected internal System.Windows.Forms.Label label1;
    }
}

using location_voiture.ado;
using location_voiture.entities;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace location_voiture
{
    public partial class FormLocation : Form
    {
        private double prixParJour = 0;

        public FormLocation()
        {
            InitializeComponent();
            ChargerClients();
            ChargerVoitures();
            AfficherLocations();
            dateTimePickerDebut.ValueChanged += DateChanged;
            dateTimePickerFin.ValueChanged += DateChanged;
            comboBoxVoiture.SelectedIndexChanged += ComboBoxVoiture_SelectedIndexChanged;
        }

        private void ChargerClients()
        {
            DataTable dt = ClientADO.Liste_Client();
            comboBoxClient.DataSource = dt;
            comboBoxClient.DisplayMember = "Nom";
            comboBoxClient.ValueMember = "CIN";
        }

        private void ChargerVoitures()
        {
            DataTable dt = VoitureADO.Liste_Voitures();
            comboBoxVoiture.DataSource = dt;
            comboBoxVoiture.DisplayMember = "Modele";
            comboBoxVoiture.ValueMember = "Matricule";
        }
        private void CalculerPrixTotal()
        {
            if (prixParJour > 0)
            {
                int jours = (dateTimePickerFin.Value.Date - dateTimePickerDebut.Value.Date).Days;
                if (jours < 1) jours = 1;

                double total = prixParJour * jours;
                txtPrixTotal.Text = total.ToString();
            }
        }


        private void AfficherLocations()
        {
            dataGridView1.DataSource = LocationADO.Liste_Locations();
        }
        private void ComboBoxVoiture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVoiture.SelectedItem is DataRowView row)
            {
                prixParJour = double.Parse(row["PrixParJour"].ToString());
                CalculerPrixTotal();
            }
        }
        private void DateChanged(object sender, EventArgs e)
        {
            CalculerPrixTotal();
        }
    

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Location l = new Location
            {
                CIN_Client = int.Parse(comboBoxClient.SelectedValue.ToString()),
                Matricule = comboBoxVoiture.SelectedValue.ToString(),
                Date_Debut = dateTimePickerDebut.Value,
                Date_Fin = dateTimePickerFin.Value,
                Prix_Total = double.Parse(txtPrixTotal.Text),
                Etat_Location = comboBoxEtat.Text
            };

            LocationADO ado = new LocationADO();
            ado.Inserer(l);
            AfficherLocations();
            MessageBox.Show("Location ajoutée avec succès!");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());


                LocationADO ado = new LocationADO();
                ado.Supprimer(id);

                AfficherLocations();
                MessageBox.Show("Suppression effectuée !");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBoxClient.SelectedValue = row.Cells["CIN_Client"].Value;
                comboBoxVoiture.SelectedValue = row.Cells["Matricule"].Value;
                dateTimePickerDebut.Value = Convert.ToDateTime(row.Cells["Date_Debut"].Value);
                dateTimePickerFin.Value = Convert.ToDateTime(row.Cells["Date_Fin"].Value);
                txtPrixTotal.Text = row.Cells["Prix_Total"].Value.ToString();
                comboBoxEtat.Text = row.Cells["Etat_Location"].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

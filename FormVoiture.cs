using location_voiture.ado;
using location_voiture.entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace location_voiture
{
    public partial class FormVoiture : Form
    {
        public FormVoiture()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = VoitureADO.Liste_Voitures();
        }

        private void ClearFields()
        {
            txtMatricule.Text = txtMarque.Text = txtModele.Text = txtCouleur.Text =
            txtCarburant.Text = txtNbPlaces.Text = txtKilometrage.Text = txtPrixParJour.Text =
            txtEtat.Text = "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Voiture v = new Voiture
            {
                Matricule = txtMatricule.Text,
                Marque = txtMarque.Text,
                Modele = txtModele.Text,
                Couleur = txtCouleur.Text,
                Carburant = txtCarburant.Text,
                NbPlaces = int.Parse(txtNbPlaces.Text),
                Kilometrage = double.Parse(txtKilometrage.Text),
                PrixParJour = double.Parse(txtPrixParJour.Text),
                Etat = txtEtat.Text
            };

            if (!VoitureADO.Existe_Voiture(v.Matricule))
            {
                new VoitureADO().Inserer(v);
                MessageBox.Show("Voiture ajoutée !");
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Cette voiture existe déjà !");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricule.Text))
            {
                MessageBox.Show("Veuillez entrer le matricule de la voiture !");
                return;
            }

            if (!int.TryParse(txtNbPlaces.Text, out int nbPlaces) ||
                !double.TryParse(txtKilometrage.Text, out double kilometrage) ||
                !double.TryParse(txtPrixParJour.Text, out double prixParJour))
            {
                MessageBox.Show("Veuillez entrer des valeurs numériques valides pour NbPlaces, Kilometrage et PrixParJour !");
                return;
            }

            Voiture v = new Voiture
            {
                Matricule = txtMatricule.Text,
                Marque = txtMarque.Text,
                Modele = txtModele.Text,
                Couleur = txtCouleur.Text,
                Carburant = txtCarburant.Text,
                NbPlaces = nbPlaces,
                Kilometrage = kilometrage,
                PrixParJour = prixParJour,
                Etat = txtEtat.Text
            };

            try
            {
                new VoitureADO().Modifier(v);
                MessageBox.Show("Voiture modifiée !");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (txtMatricule.Text != "")
            {
                new VoitureADO().Supprimer(txtMatricule.Text);
                MessageBox.Show("Voiture supprimée !");
                LoadData();
                ClearFields();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtMatricule.Text != "")
            {
                dataGridView1.DataSource = VoitureADO.Liste_Voitures(txtMatricule.Text);
            }
            else if (txtModele.Text != "")
            {
                dataGridView1.DataSource = VoitureADO.Liste_VoituresByModele(txtModele.Text);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMatricule.Text = row.Cells["Matricule"].Value.ToString();
                txtMarque.Text = row.Cells["Marque"].Value.ToString();
                txtModele.Text = row.Cells["Modele"].Value.ToString();
                txtCouleur.Text = row.Cells["Couleur"].Value.ToString();
                txtCarburant.Text = row.Cells["Carburant"].Value.ToString();
                txtNbPlaces.Text = row.Cells["NbPlaces"].Value.ToString();
                txtKilometrage.Text = row.Cells["Kilometrage"].Value.ToString();
                txtPrixParJour.Text = row.Cells["PrixParJour"].Value.ToString();
                txtEtat.Text = row.Cells["Etat"].Value.ToString();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblCarburant_Click(object sender, EventArgs e)
        {

        }

        private void txtMarque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

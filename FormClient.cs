using System;
using System.Windows.Forms;
using location_voiture.entities;
using location_voiture.ado;

namespace location_voiture
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            btnAjouter.Click += BtnAjouter_Click;
            btnModifier.Click += BtnModifier_Click;
            btnSupprimer.Click += BtnSupprimer_Click;
            btnRechercher.Click += BtnRechercher_Click;
            this.Load += FormClient_Load;
            dgvClient.CellClick += DgvClient_CellClick;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = ClientADO.Liste_Client();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Client c = new Client
                {
                    cin_cl = int.Parse(txtCin.Text),
                    nom_cl = txtNom.Text,
                    prenom_cl = txtPren.Text,
                    tel_cl = txtTel.Text,
                    adresse_cl = txtAdresse.Text
                };

                ClientADO clientAdo = new ClientADO();

                if (!ClientADO.Existe_Client(c.cin_cl))
                {
                    clientAdo.Inserer(c);
                    MessageBox.Show("Client ajouté avec succès !");
                    dgvClient.DataSource = ClientADO.Liste_Client();
                }
                else
                {
                    MessageBox.Show("Un client avec ce CIN existe déjà !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Client c = new Client
                {
                    cin_cl = int.Parse(txtCin.Text),
                    nom_cl = txtNom.Text,
                    prenom_cl = txtPren.Text,
                    tel_cl = txtTel.Text,
                    adresse_cl = txtAdresse.Text
                };

                ClientADO clientAdo = new ClientADO();

                if (ClientADO.Existe_Client(c.cin_cl))
                {
                    clientAdo.Modifier(c);
                    MessageBox.Show("Client modifié avec succès !");
                    dgvClient.DataSource = ClientADO.Liste_Client();
                }
                else
                {
                    MessageBox.Show("Client introuvable !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int cin = int.Parse(txtCin.Text);
                ClientADO clientAdo = new ClientADO();

                if (ClientADO.Existe_Client(cin))
                {
                    clientAdo.Supprimer(cin);
                    MessageBox.Show("Client supprimé !");
                    dgvClient.DataSource = ClientADO.Liste_Client();
                }
                else
                {
                    MessageBox.Show("Client introuvable !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCin.Text))
                {
                    int cin = int.Parse(txtCin.Text);
                    dgvClient.DataSource = ClientADO.Liste_Client(cin);
                }
                else if (!string.IsNullOrEmpty(txtNom.Text))
                {
                    dgvClient.DataSource = ClientADO.Liste_Client(txtNom.Text);
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un CIN ou un Nom pour rechercher !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void DgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCin.Text = dgvClient.Rows[e.RowIndex].Cells["CIN"].Value.ToString();
                txtNom.Text = dgvClient.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                txtPren.Text = dgvClient.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                txtTel.Text = dgvClient.Rows[e.RowIndex].Cells["Tel"].Value.ToString();
                txtAdresse.Text = dgvClient.Rows[e.RowIndex].Cells["Adresse"].Value.ToString();
            }
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {

        }
    }
}

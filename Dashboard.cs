using System;
using System.Windows.Forms;

namespace location_voiture
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormClient fc = new FormClient();
            fc.ShowDialog();
        }

        private void btnVoiture_Click(object sender, EventArgs e)
        {
            FormVoiture fv = new FormVoiture();
            fv.ShowDialog();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            FormLocation fl = new FormLocation();
            fl.ShowDialog();
        }
    }
}

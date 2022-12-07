using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGUI
{
    public partial class FrmListeDevis : Form
    {
        public FrmListeDevis()
        {
            InitializeComponent();

            foreach (Devis dev in DevisBLL.GetDevis())
            {
                dgvDevis.Rows.Add(dev.Code, dev.Date, dev.Taux_tva, dev.Client.Nom, dev.Statut.Libelle);
            }

            foreach (Client cli in ClientBLL.GetClient())
            {
                this.comboClient.Items.Add(cli.Nom);
            }

            foreach (Statut sta in StatutBLL.GetStatut())
            {
                this.comboStatut.Items.Add(sta.Libelle);
            }

            PanelDeleteDevis.Hide();
        }

        private void retSynt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSyntheseClients FrmSyntheseClients;
            FrmSyntheseClients = new FrmSyntheseClients();
            FrmSyntheseClients.Closed += (s, args) => this.Close();
            FrmSyntheseClients.ShowDialog(); // retour synthese
            this.Close();
        }

        private void dgvDevis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nom_client;
            string libelle_statut;

            nom_client = dgvDevis.CurrentRow.Cells[3].Value.ToString();
            libelle_statut = dgvDevis.CurrentRow.Cells[4].Value.ToString();

            panel1.Show();
            textCodeDevis.Text = dgvDevis.CurrentRow.Cells[0].Value.ToString();
            // dateTimePicker1 = dgvDevis.CurrentRow.Cells[1];
            textTauxTVA.Text = dgvDevis.CurrentRow.Cells[2].Value.ToString();
            comboClient.SelectedIndex = comboClient.FindStringExact(nom_client);
            comboStatut.SelectedIndex = comboStatut.FindStringExact(libelle_statut);
        }
    }
}

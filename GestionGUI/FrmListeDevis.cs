using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBLL;
using GestionBO;
using GestionDAL;

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
            int code_devis;
            string nom_client;
            string libelle_statut;
            DateTime date;

            int.TryParse(dgvDevis.CurrentRow.Cells[0].Value.ToString(), out code_devis);
            nom_client = dgvDevis.CurrentRow.Cells[3].Value.ToString();
            libelle_statut = dgvDevis.CurrentRow.Cells[4].Value.ToString();

            panel1.Show();
            textCodeDevis.Text = dgvDevis.CurrentRow.Cells[0].Value.ToString();
            // dateTimePicker1.Text = dgvDevis.CurrentRow.Cells[1].ToString();
            date = DateTime.Parse(dgvDevis.CurrentRow.Cells[1].Value.ToString());
            dateTimePicker1.Value = date;
            textTauxTVA.Text = dgvDevis.CurrentRow.Cells[2].Value.ToString();
            comboClient.SelectedIndex = comboClient.FindStringExact(nom_client);
            comboStatut.SelectedIndex = comboStatut.FindStringExact(libelle_statut);
        }

        private void SupprimerDevis_Click(object sender, EventArgs e)
        {
            PanelDeleteDevis.Show();
        }

        private void AnnulerDeleteDevis_Click(object sender, EventArgs e)
        {
            PanelDeleteDevis.Hide();
        }

        private void ConfirmerDeleteDevis_Click(object sender, EventArgs e)
        {
            PanelDeleteDevis.Hide();

            int id;

            int.TryParse(textCodeDevis.Text, out id);

            // ProduitBLL.SupprimerProduit(id);
            int delete = DevisBLL.SupprimerDevis(id);

            this.Hide();
            FrmListeDevis FrmListeDevis;
            FrmListeDevis = new FrmListeDevis();
            FrmListeDevis.Closed += (s, args) => this.Close();
            FrmListeDevis.ShowDialog(); // ouverture du formulaire list produit
            this.Close();
        }
    }
}

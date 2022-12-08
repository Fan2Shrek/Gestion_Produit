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

            this.comboClient.DataSource = (ClientBLL.GetClient());
            this.comboClient.DisplayMember = "Nom";

            this.comboStatut.DataSource = (StatutBLL.GetStatut());
            this.comboStatut.DisplayMember = "Libelle";

            this.cbxProduit.DataSource = (ProduitBLL.GetProduit());
            this.cbxProduit.DisplayMember = "Libelle";


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
            dgvProduitsDevis.Rows.Clear();
            int code_devis;
            string nom_client;
            string libelle_statut;
            float tauxTVADevis;
            DateTime date;
            float prixTotalDevis = 0;
            float prixTotalDevisAvecRemise = 0;
            float montantTVA;
            float montantTTC = 0;


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

            foreach (Contenir con in ContenirBLL.GetConteneurs(code_devis))
            {
                float prixTotal = con.Produit.Prix * con.Quantite;
                dgvProduitsDevis.Rows.Add(con.Produit.Code, con.Produit.Libelle, con.Produit.Prix, con.Quantite, con.Remise, prixTotal);
                prixTotalDevis = prixTotalDevis + prixTotal;
                prixTotalDevisAvecRemise = prixTotalDevisAvecRemise + (prixTotal - (prixTotal * (con.Remise / 100)));
            }
            textMontantHTsansTauxRemise.Text = prixTotalDevis.ToString();
            textMontantHTAvecRemise.Text = prixTotalDevisAvecRemise.ToString();
            tauxTVADevis = float.Parse(dgvDevis.CurrentRow.Cells[2].Value.ToString());
            tauxTVADevis = tauxTVADevis / 100;
            montantTVA = prixTotalDevisAvecRemise * tauxTVADevis;
            textMontantTVA.Text = montantTVA.ToString();
            montantTTC = prixTotalDevisAvecRemise + montantTVA;
            textMontantTTC.Text = montantTTC.ToString();
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
            FrmListeDevis.ShowDialog(); // ouverture du formulaire list devis
            this.Close();
        }

        private void ModifierDevis_Click(object sender, EventArgs e)
        {
            int id;
            DateTime date = DateTime.Parse(dateTimePicker1.Value.ToString());
            int.TryParse(textCodeDevis.Text, out id);
            Client cli = (Client)comboClient.SelectedItem;
            Statut stat = (Statut)comboStatut.SelectedItem;
            float tva;
            float.TryParse(textTauxTVA.Text, out tva);


            Devis dev = new Devis(id, date, tva, cli, stat);

            int qte;
            int.TryParse(txtQte.Text.ToString(), out qte);
            int remise;
            int.TryParse(txtRemise.Text.ToString(), out remise);

            DevisBLL.ModifierDevis(dev);

            this.Hide();
            FrmListeDevis FrmListeDevis;
            FrmListeDevis = new FrmListeDevis();
            FrmListeDevis.Closed += (s, args) => this.Close();
            FrmListeDevis.ShowDialog(); // ouverture du formulaire list devis
            this.Close();
        }

        private void actualiserDevis_Click(object sender, EventArgs e)
        {
            dgvDevis.Rows.Clear();

            foreach (Devis dev in DevisBLL.GetDevis())
            {
                dgvDevis.Rows.Add(dev.Code, dev.Date, dev.Taux_tva, dev.Client.Nom, dev.Statut.Libelle);
            }
        }

        private void dgvProduitsDevis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textQuantite.Text = dgvProduitsDevis.CurrentRow.Cells[2].Value.ToString();
            textTauxRemiseDevis.Text = dgvProduitsDevis.CurrentRow.Cells[3].Value.ToString();

            int id;
            int.TryParse(dgvProduitsDevis.CurrentRow.Cells[0].Value.ToString(), out id);

            txtQte.Text = dgvProduitsDevis.CurrentRow.Cells[3].Value.ToString();
            txtRemise.Text = dgvProduitsDevis.CurrentRow.Cells[4].Value.ToString();

            foreach (Produit pro in ProduitBLL.GetProduit())
            {
                if (pro.Code == id)
                {
                    cbxProduit.SelectedItem = cbxProduit.FindStringExact(pro.Libelle);
                    break;
                }
            }

        }
    }
}

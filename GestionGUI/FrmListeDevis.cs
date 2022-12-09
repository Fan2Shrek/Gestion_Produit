﻿using System;
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
                this.comboClientAjout.Items.Add(cli.Nom);
            }

            foreach (Statut sta in StatutBLL.GetStatut())
            {
                this.comboStatutAjout.Items.Add(sta.Libelle);
            }

            foreach (Produit pro in ProduitBLL.GetProduit())
            {
                this.comboProduitAjout.Items.Add(pro.Libelle);
            }

            this.comboClient.DataSource = (ClientBLL.GetClient());
            this.comboClient.DisplayMember = "Nom";

            this.comboStatut.DataSource = (StatutBLL.GetStatut());
            this.comboStatut.DisplayMember = "Libelle";

            PanelDeleteDevis.Hide();
            panelAjoutDevis.Hide();
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

            if (txtQte.Text == "" || txtRemise.Text.ToString() == "")
            {
                lblErreur.ForeColor = Color.Red;
            }
            else {
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
            txtQte.Text = dgvProduitsDevis.CurrentRow.Cells[2].Value.ToString();
            txtRemise.Text = dgvProduitsDevis.CurrentRow.Cells[3].Value.ToString();

            int id;
            int.TryParse(dgvProduitsDevis.CurrentRow.Cells[0].Value.ToString(), out id);

            txtQte.Text = dgvProduitsDevis.CurrentRow.Cells[3].Value.ToString();
            txtRemise.Text = dgvProduitsDevis.CurrentRow.Cells[4].Value.ToString();

        }

        private void lblDevis_Click(object sender, EventArgs e)
        {

        }

        private void AjouterDevis_Click(object sender, EventArgs e)
        {
            panelAjoutDevis.Show();
            textTVAAjout.Text = "20";
        }

        private void btnFermerAjoutDevis_Click(object sender, EventArgs e)
        {
            panelAjoutDevis.Hide();
        }

        private void btnConfirmerAjoutDevis_Click(object sender, EventArgs e)
        {
            string strQuantite = textQuantiteAjout.Text;
            string strTVA = textTVAAjout.Text;
            string strRemise = textRemiseAjout.Text;
            string strProduit = comboProduitAjout.Text;
            string strClient = comboClientAjout.Text;
            string strStatut = comboStatutAjout.Text;
            bool saisie = true;

            if (strQuantite == "")
            {
                lblQuantiteVide.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblQuantiteVide.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (strTVA == "")
            {
                lblTVAVide.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblTVAVide.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (strRemise == "")
            {
                lblRemiseVide.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblRemiseVide.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
            if (strProduit == "")
            {
                lblProduitVide.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblProduitVide.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (strClient == "")
            {
                lblClientVide.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblClientVide.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (strStatut == "")
            {
                lblStatutVide.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblStatutVide.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                int code_devis;
                DateTime date = DateTime.Parse(dateTimePicker2.Value.ToString());
                int quantite;
                int.TryParse(textQuantiteAjout.Text, out quantite);
                float tauxTVA;
                float.TryParse(textTVAAjout.Text, out tauxTVA);
                float remise;
                float.TryParse(textRemiseAjout.Text, out remise);

                foreach (Client cli in ClientBLL.GetClient())
                {
                    if (cli.Nom == comboClientAjout.Text)
                    {
                        foreach (Statut sta in StatutBLL.GetStatut())
                        {
                            if (sta.Libelle == comboStatutAjout.Text)
                            {
                                Devis devis = new Devis(0, date, tauxTVA, cli, sta);

                                DevisBLL.CreerDevis(devis);

                                foreach (Produit pro in ProduitBLL.GetProduit())
                                {
                                    if (pro.Libelle == comboProduitAjout.Text)
                                    {
                                        //code_devis = DevisBLL.GetCodeDevis(date, tauxTVA, cli, sta);
                                        Contenir contenir = new Contenir(devis, pro, quantite, remise);

                                        this.Hide();
                                        FrmListeDevis FrmListeDevis;
                                        FrmListeDevis = new FrmListeDevis();
                                        FrmListeDevis.Closed += (s, args) => this.Close();
                                        FrmListeDevis.ShowDialog(); // ouverture du formulaire list devis
                                        this.Close();

                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

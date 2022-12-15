using GestionBLL;
using GestionBO;

namespace GestionGUI
{
    public partial class FrmSyntheseClients : Form
    {
        public FrmSyntheseClients()
        {
            InitializeComponent();

            foreach (Client cli in ClientBLL.GetClient())
            {
                List < Devis > listDevis = cli.LesDevis;
                int taille = listDevis.Count;
                double nbAcc =0, nbRef=0, nbAtt = 0;

                foreach(Devis dev in listDevis)
                {
                    switch (dev.Statut.Libelle)
                    {
                        case "Accepté":
                            nbAcc++;
                            break;
                        case "Refusé":
                            nbRef++;
                            break;
                        case "En attente":
                            nbAtt++;
                            break;
                        default:
                            break;
                    }
                }

                double prAcc = 0, prRef = 0, prAtt = 0;

                if (taille > 0)
                {
                    prAcc = (nbAcc / taille) * 100;
                    prRef = (nbRef / taille) * 100;
                    prAtt = (nbAtt / taille) * 100;
                }

                dataGridSynthese.Rows.Add(cli.Nom, taille, nbAcc, prAcc + "%", prAtt + "%", prRef + "%", 0);
            }

        }

        private void syntheseProduit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListeProduits FrmListesProduit;
            FrmListesProduit = new FrmListeProduits();
            FrmListesProduit.Closed += (s, args) => this.Close();
            FrmListesProduit.ShowDialog(); // ouverture du formulaire list produit
            this.Close();
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            ConnexionForm ConnexionForm;
            ConnexionForm = new ConnexionForm();
            ConnexionForm.Closed += (s, args) => this.Close();
            ConnexionForm.ShowDialog(); // déconnexion
            this.Close();*/
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListeClients FrmListeClients;
            FrmListeClients = new FrmListeClients();
            FrmListeClients.Closed += (s, args) => this.Close();
            FrmListeClients.ShowDialog(); // ouverture du formulaire list client
            this.Close();
        }

        private void btnDevis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListeDevis FrmListeDevis;
            FrmListeDevis = new FrmListeDevis();
            FrmListeDevis.Closed += (s, args) => this.Close();
            FrmListeDevis.ShowDialog(); // ouverture du formulaire list devis
            this.Close();
        }

        private void dataGridSynthese_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

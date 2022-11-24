using GestionBLL;
using GestionBO;
using GestionDAL;
using System.Configuration;
using System.Drawing;

namespace GestionGUI
{
    public partial class FrmListeClients : Form
    {
        public FrmListeClients()
        {
            InitializeComponent();
            ClientBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            foreach (Client cli in ClientBLL.GetClient())
            {
                dgvClient.Rows.Add(cli.Code, cli.Nom, cli.Prenom, cli.Email, cli.Fax, cli.Telephone,
                    cli.Rue_facturation, cli.Cp_facturation, cli.Ville_facturation,
                    cli.Rue_livraison, cli.Cp_livraison, cli.Ville_livraison);
            }

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

        private void FrmListeProduits_Load(object sender, EventArgs e)
        {

        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Show();
            textCodeCli.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
            textNomCli.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            textPrenomCli.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string nom = textNomCli.Text;
            string prenom = textPrenomCli.Text;
            string email = textEmailCli.Text;
            string telephone = textTelCli.Text;
            string fax = textFaxCli.Text;
            string rueFactu = textRueFactuCli.Text;
            string cpFactu = textCPFactuCli.Text;
            string villeFact = textVilleFactCli.Text;
            string rueLivraison = textRueLivraisonCli.Text;
            string cpLivraison = CodePostalLivraiCli.Text;
            string villeLivraison = textVilleLivraiCli.Text;
            bool saisie = true;

            if (nom == "" || prenom == "" || email == "" || telephone == "" || fax == "" || rueFactu == "" ||
                cpFactu == "" || villeFact == "" || rueLivraison == "" || cpLivraison == "" || villeLivraison == "")
            {
                lblErrorClient.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorClient.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                int id;
                int.TryParse(textCodeCli.Text, out id);
                             
                // Création de l'objet client avec le nom récupéré dans la GUI
                Client cli = new Client(id, nom, prenom, email, telephone, fax, 
                    rueFactu, cpFactu, villeFact, rueLivraison, cpLivraison, villeLivraison);

                // Appel de la méthode CreerProduit de la couche BLL
                ClientBLL.ModifierClient(cli);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int id;

            int.TryParse(textCodeCli.Text, out id);
            ProduitBLL.SupprimerProduit(id);
        }

        private void textTelCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCodeCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualiserClient_Click(object sender, EventArgs e)
        {
            dgvClient.Rows.Clear();

            foreach (Client cli in ClientBLL.GetClient())
            {
                dgvClient.Rows.Add(cli.Code, cli.Nom, cli.Prenom, cli.Email, cli.Telephone);
            }
        }

        private void AjouterCli_Click(object sender, EventArgs e)
        {
            string nom = textNomCli.Text;
            string prenom = textPrenomCli.Text;
            string email = textEmailCli.Text;
            string telephone = textTelCli.Text;
            string fax = textFaxCli.Text;
            string rueFactu = textRueFactuCli.Text;
            string cpFactu = textCPFactuCli.Text;
            string villeFact = textVilleFactCli.Text;
            string rueLivraison = textRueLivraisonCli.Text;
            string cpLivraison = CodePostalLivraiCli.Text;
            string villeLivraison = textVilleLivraiCli.Text;
            bool saisie = true;

            if (nom == "" || prenom == "" || email == "" || telephone == "" || fax == "" || rueFactu == "" ||
                cpFactu == "" || villeFact == "" || rueLivraison == "" || cpLivraison == "" || villeLivraison == "")
            {
                lblErrorClient.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorClient.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                int id;
                int.TryParse(textCodeCli.Text, out id);

                // Création de l'objet client avec le nom récupéré dans la GUI
                Client cli = new Client(id, nom, prenom, email, telephone, fax,
                    rueFactu, cpFactu, villeFact, rueLivraison, cpLivraison, villeLivraison);

                // Appel de la méthode CreerProduit de la couche BLL
                ClientBLL.AjouterClient(cli);
            }
        }
    }
}

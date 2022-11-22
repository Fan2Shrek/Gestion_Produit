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
                dgvClient.Rows.Add(cli.Code, cli.Nom, cli.Prenom, cli.Telephone, cli.Email);
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

        private void ajouterProdui_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAjoutProduit FrmAjoutProduit;
            FrmAjoutProduit = new FrmAjoutProduit();
            FrmAjoutProduit.Closed += (s, args) => this.Close();
            FrmAjoutProduit.ShowDialog(); // ouverture du formulaire ajout produit
            this.Close();
        }

        private void FrmListeProduits_Load(object sender, EventArgs e)
        {

        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Show();
            textCode.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
            textLibelle.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            textPrix.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
        }

        private void actualiserProduit_Click(object sender, EventArgs e)
        {
            dgvClient.Rows.Clear();

            foreach (Produit pro in ProduitBLL.GetProduit())
            {
                dgvClient.Rows.Add(pro.Code, pro.Libelle, pro.Prix, pro.Categorie.Libelle);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string libelle = textLibelle.Text;
            string prix = textPrix.Text;
            string categorie = listCategorie.Text;
            bool saisie = true;

            if (libelle == "")
            {
                lblErrorLibellé.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorLibellé.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (prix == "")
            {
                lblErrorPrix.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorPrix.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (categorie == "")
            {
                lblErrorCategorie.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorCategorie.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                float temp;
                float.TryParse(textPrix.Text, out temp);
                int id;

                int.TryParse(textCode.Text, out id);

                foreach (Categorie cate in CategorieBLL.GetCategorie())
                {
                    if (cate.Libelle == listCategorie.Text)
                    {
                        // Création de l'objet produit avec le nom récupéré dans la GUI
                        Produit pro = new Produit(id, libelle, temp, cate);

                        // Appel de la méthode CreerProduit de la couche BLL
                        ProduitBLL.ModifierProduit(pro);

                        break;
                    }
                };

            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int id;

            int.TryParse(textCode.Text, out id);
            ProduitBLL.SupprimerProduit(id);
        }
    }
}

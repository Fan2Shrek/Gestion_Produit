using GestionBLL;
using GestionBO;
using GestionGUI;
using System.Configuration;
using System.Drawing;

namespace GestionGUI
{
    public partial class FrmListeProduits : Form
    {
        public FrmListeProduits()
        {
            InitializeComponent();
            ProduitBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            foreach (Produit pro in ProduitBLL.GetProduit())
            {
                dgvProduit.Rows.Add(pro.Code, pro.Libelle, pro.Prix, pro.Categorie.Libelle);
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

        private void actualiserProduit_Click(object sender, EventArgs e)
        {
            dgvProduit.Rows.Clear();

            foreach (Produit pro in ProduitBLL.GetProduit())
            {
                dgvProduit.Rows.Add(pro.Code, pro.Libelle, pro.Prix, pro.Categorie.Libelle);
            }
        }
    }
}

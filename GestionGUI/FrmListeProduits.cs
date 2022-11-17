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
            FrmSyntheseClients FrmSyntheseClients;
            FrmSyntheseClients = new FrmSyntheseClients();
            FrmSyntheseClients.ShowDialog(); // ouverture du formulaire synthexe client (retour)
        }

        private void ajouterProdui_Click(object sender, EventArgs e)
        {
            FrmAjoutProduit FrmListePro;
            FrmListePro = new FrmAjoutProduit();
            FrmListePro.ShowDialog(); // btn ajouter produit
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

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

            // Blocage de la génération automatique des colonnes
            dgvProduit.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn CodeColumn = new DataGridViewTextBoxColumn();
            CodeColumn.DataPropertyName = "code_produit";
            CodeColumn.HeaderText = "Code";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn LibelleColumn = new DataGridViewTextBoxColumn();
            LibelleColumn.DataPropertyName = "libelle_produit";
            LibelleColumn.HeaderText = "Libelle";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrixColumn = new DataGridViewTextBoxColumn();
            PrixColumn.DataPropertyName = "prix_vente_ht_produit";
            PrixColumn.HeaderText = "Prix";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn CodeCategorieColumn = new DataGridViewTextBoxColumn();
            CodeCategorieColumn.DataPropertyName = "code_categorie";
            CodeCategorieColumn.HeaderText = "Catégorie";

            // Ajout des 2 en-têtes de colonne au datagridview
            dgvProduit.Columns.Add(CodeColumn);
            dgvProduit.Columns.Add(LibelleColumn);
            dgvProduit.Columns.Add(PrixColumn);
            dgvProduit.Columns.Add(CodeCategorieColumn);

            // Définition du style apporté au datagridview
            dgvProduit.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvProduit.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List de produit à afficher dans le datagridview
            List<Produit> liste = new List<Produit>();
            liste = ProduitBLL.GetProduit();

            // Rattachement de la List à la source de données du datagridview
            dgvProduit.DataSource = liste;
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
    }
}

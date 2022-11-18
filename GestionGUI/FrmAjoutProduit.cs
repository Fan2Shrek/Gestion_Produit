using GestionBLL;
using GestionBO;
using GestionDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGUI
{
    public partial class FrmAjoutProduit : Form
    {
        public FrmAjoutProduit()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire

            foreach (Categorie cate in CategorieDAO.GetCategorie())
            {
                this.CategorieProAdd.Items.Add(cate.Libelle);
            }

            ProduitBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void FrmAjoutProduit_Load(object sender, EventArgs e)
        {

        }

        private void addPro_Click(object sender, EventArgs e)
        {
            string libelle = libelleProAdd.Text;
            string prix = PrixProAdd.Text;
            string categorie = CategorieProAdd.Text;
            bool saisie = true;

            if(libelle == "")
            {
                lblErrorLibellé.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorLibellé.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if(prix == "")
            {
                lblErrorPrix.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorPrix.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if(categorie == "")
            {
                lblErrorCategorie.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorCategorie.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if(saisie)
            {
                float temp;
                float.TryParse(PrixProAdd.Text, out temp);

                foreach (Categorie cate in CategorieBLL.GetCategorie())
                {
                    if (cate.Libelle == CategorieProAdd.Text)
                    {
                        // Création de l'objet produit avec le nom récupéré dans la GUI
                        Produit pro = new Produit(0, libelleProAdd.Text, temp, cate);

                        // Appel de la méthode CreerProduit de la couche BLL
                        ProduitBLL.CreerProduit(pro);


                        this.Hide();
                        FrmListeProduits FrmListeProduits;
                        FrmListeProduits = new FrmListeProduits();
                        FrmListeProduits.Closed += (s, args) => this.Close();
                        FrmListeProduits.ShowDialog(); // ouverture du formulaire list produit
                        this.Close();

                        break;
                    }
                };

            }
            
        }

        private void btnRetourInPro_Click(object sender, EventArgs e)
        {   
            this.Hide();
            FrmListeProduits FrmListeProduits;
            FrmListeProduits = new FrmListeProduits();
            FrmListeProduits.Closed += (s, args) => this.Close();
            FrmListeProduits.ShowDialog(); // ouverture du formulaire list produit
            this.Close();
        }
    }
}

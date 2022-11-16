using GestionBO;
using System.Data.SqlClient;

namespace GestionDAL
{
    public class ProduitDAO
    {
        private static ProduitDAO unProduitDAO;

        // Accesseur en lecture, renvoi une instance
        public static ProduitDAO GetunProduitDAO()
        {
            if (unProduitDAO == null)
            {
                unProduitDAO = new ProduitDAO();
            }
            return unProduitDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table produit : VIEW

        public static List<Produit> GetProduit()
        {
            int code;
            string libelle;
            float prix;
            int codeCatagorie;

            Produit unProduit;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Produit
            List<Produit> lesProduits = new List<Produit>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM produit";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_produit"].ToString());
                codeCatagorie = Int32.Parse(monReader["code_categorie"].ToString());
                prix = float.Parse(monReader["prix_vente_ht_produit"].ToString());

                if (monReader["libelle_produit"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["libelle_produit"].ToString();
                }

                unProduit = new Produit(code, libelle, prix, codeCatagorie);
                lesProduits.Add(unProduit);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesProduits;
        }
    }
}

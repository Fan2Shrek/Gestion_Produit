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
            string codeCatagorie;

            Produit unProduit;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Produit
            List<Produit> lesProduits = new List<Produit>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT code_produit, libelle_produit, prix_vente_ht_produit, " +
                "libelle_categorie FROM produit, " +
                "categorie WHERE produit.code_categorie = categorie.code_categorie";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_produit"].ToString());
                codeCatagorie = monReader["libelle_categorie"].ToString();
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

        // Cette méthode insert un nouveau produit passé en paramètre dans la BD
        public static int AjoutProduit(Produit unProduit)
        {
            int nbEnr;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO produit values (@libelle, @prix, @codeCategorie)";
            cmd.Parameters.Add(new SqlParameter("@libelle", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@libelle"].Value = unProduit.Libelle;

            cmd.Parameters.Add(new SqlParameter("@prix", System.Data.SqlDbType.Float));
            cmd.Parameters["@prix"].Value = unProduit.Prix;

            cmd.Parameters.Add(new SqlParameter("@codeCategorie", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeCategorie"].Value = unProduit.Categorie;

            SqlDataReader monReader = cmd.ExecuteReader();

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateProduit(Produit unProduit)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE T_produit SET libelle_produit = @libelle," +
                "prix_vente_ht_produit = @prix," +
                "code_categorie = @codeCategorie" +
                "WHERE code_produit = @codeProduit";
            cmd.Parameters.Add(new SqlParameter("@libelle", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@libelle"].Value = unProduit.Libelle;

            cmd.Parameters.Add(new SqlParameter("@prix", System.Data.SqlDbType.Float));
            cmd.Parameters["@prix"].Value = unProduit.Prix;

            cmd.Parameters.Add(new SqlParameter("@codeCategorie", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeCategorie"].Value = unProduit.Categorie;

            cmd.Parameters.Add(new SqlParameter("@codeProduit", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeProduit"].Value = unProduit.Code;

            cmd.Connection = maConnexion;
            
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int DeleteProduit(int id)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM T_produit WHERE code_produit = " + id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}

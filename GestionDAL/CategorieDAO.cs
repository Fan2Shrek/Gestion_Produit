using GestionBO;
using System.Data.SqlClient;

namespace GestionDAL
{
    public class CategorieDAO
    {
        private static CategorieDAO unCategorieDAO;

        // Accesseur en lecture, renvoi une instance
        public static CategorieDAO GetunCategorieDAO()
        {
            if (unCategorieDAO == null)
            {
                unCategorieDAO = new CategorieDAO();
            }
            return unCategorieDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Categorie : VIEW
        public static List<Categorie> GetCategorie()
        {
            int code;
            string libelle;

            Categorie unCategorie;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Categorie
            List<Categorie> lesCategories = new List<Categorie>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM categorie";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_categorie"].ToString());

                if (monReader["libelle_categorie"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["libelle_categorie"].ToString();
                }

                unCategorie = new Categorie(code, libelle);
                lesCategories.Add(unCategorie);
            }

            // Fermeture de la connexion
            monReader.Close();
            maConnexion.Close();
            return lesCategories;
        }
    }
}

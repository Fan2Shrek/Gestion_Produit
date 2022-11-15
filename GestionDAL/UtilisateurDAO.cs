using GestionBO;
using System.Data.SqlClient;

namespace GestionDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        public static Utilisateur? getUserByName(string name)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur WHERE login_utilisateur = @nom";
            cmd.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar, 40));
            cmd.Parameters["@nom"].Value = name;

            SqlDataReader monReader = cmd.ExecuteReader();
            monReader.Read();

            if (monReader.HasRows)
            {
                int id;
                int.TryParse(monReader["code_utilisateur"].ToString(), out id);
                string nom = monReader["login_utilisateur"].ToString();
                string password = monReader["mot_de_passe_utilisateur"].ToString();
                monReader.Close();

                return new Utilisateur(id, nom, password);
            }
            else
            {
                monReader.Close();
                return null;
            }
        }
    }
}
using GestionDAL;
using GestionBO;

namespace GestionBLL
{
    public class UtilisateurBLL
    {
        private static UtilisateurBLL uneGestionUtilisateurs; // objet BLL

        public static UtilisateurBLL GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new UtilisateurBLL();
            }
            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Utilisateur> GetUtilisateurs()
        {
            return UtilisateurDAO.GetUtilisateurs();
        }

        public static Utilisateur nomUtilisateur(string name)
        {
            return UtilisateurDAO.getUserByName(name);
        }
    }
}
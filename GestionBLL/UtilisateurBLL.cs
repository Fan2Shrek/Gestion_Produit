using GestionDAL;
using GestionBO;

namespace GestionBLL
{
    public class UtilisateurBLL
    {
        private static UtilisateurBLL uneGestionUtilisateurs; // objet BLL
        public static Utilisateur nomUtilisateur(string name)
        {
            return UtilisateurDAO.getUserByName(name);
        }
    }
}
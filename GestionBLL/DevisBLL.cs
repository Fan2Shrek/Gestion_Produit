using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDAL;
using GestionBO;
using System.Configuration;

namespace GestionBLL
{
    public class DevisBLL
    {
        private static DevisBLL uneGestionDevis; // objet BLL

        // Accesseur en lecture
        public static DevisBLL GetGestionUtilisateurs()
        {
            if (uneGestionDevis == null)
            {
                uneGestionDevis = new DevisBLL();
            }
            return uneGestionDevis;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetProduit() de la DAL : VIEW
        public static List<Devis> GetDevis()
        {
            return DevisDAO.GetDevis();
        }

        // Méthode qui renvoit le code du client
        public static int ClientDevis(int code)
        {
            return DevisDAO.SelectClientDevis(code);
        }

        // Méthode qui renvoit le code du statut
        public static int StatutDevis(int code)
        {
            return DevisDAO.SelectStatutDevis(code);
        }

        // Méthode qui renvoi l’objet Produit en l'ajoutant à la
        // BD avec la méthode AjoutProduit de la DAL
        public static int CreerProduit(Produit ut)
        {
            return ProduitDAO.AjoutProduit(ut);
        }

        public static int SupprimerDevis(int id)
        {
            return DevisDAO.DeleteDevis(id);
        }
    }
}

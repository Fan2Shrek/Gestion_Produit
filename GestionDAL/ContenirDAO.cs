using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionBO;

namespace GestionDAL
{
    public class ContenirDAO
    {
        private static ContenirDAO unContenirDAO;

        // Accesseur en lecture, renvoi une instance
        public static ContenirDAO GetunContenirDAO()
        {
            if (unContenirDAO == null)
            {
                unContenirDAO = new ContenirDAO();
            }
            return unContenirDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table produit : VIEW

        public static List<Contenir> GetContenir()
        {
            int code_devis;
            int code_produit;
            int quantite;
            float remise;
            Contenir unConteneur;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Produit
            List<Contenir> lesConteneurs = new List<Contenir>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM contenir";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code_devis = Int32.Parse(monReader["code_devis"].ToString());
                code_produit = Int32.Parse(monReader["code_produit"].ToString());
                quantite = Int32.Parse(monReader["quantite"].ToString());
                remise = float.Parse(monReader["remise"].ToString());

                unConteneur = new Contenir(code_devis, code_produit, quantite, remise);
                lesConteneurs.Add(unConteneur);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesConteneurs;
        }

        public static int GetQuantiteDevis(int code)
        {
            int nbEnr;
            int quantite;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "SELECT quantite FROM contenir WHERE code_devis = " + code;

            nbEnr = cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            quantite = (int)reader["quantite"];
            reader.Close();

            // Fermeture de la connexion
            maConnexion.Close();
            return quantite;
        }
    }
}
